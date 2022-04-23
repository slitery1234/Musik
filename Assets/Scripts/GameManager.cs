using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource TheMusic;

    public bool StartPlaying;

    public Beat TheBeat;

    public static GameManager instance;
    
    public int CurrentScore;
    public int ScorePerNote;
    public int CurrentCombo;

    public int TotalNotes;
    public int MissHit;
    public int BadHit;
    public int GoodHit;
    public int PerfectHit;
    public int CriticalHit;


    public Text ScoreText;
    public Text ComboText;
    public Text JudgeText;
    public Text RecordText;
    public string Name;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        ScoreText.text = "Score: 0";
        ComboText.text = "";
        JudgeText.text = "Press any button to Start";
        CurrentCombo = 0;
        CurrentScore = 0;
        TotalNotes = FindObjectsOfType<Note>().Length;

        if(Name == "HuaSuiYue")
        {
            RecordText.text = "Record: " + PlayerPrefs.GetInt("HuaSuiYueScore").ToString();
        }
        else if(Name == "FreedomDive")
        {
            RecordText.text = "Record: " + PlayerPrefs.GetInt("FreedomDiveScore").ToString();
        }
        else if(Name == "Lemon")
        {
             RecordText.text = "Record: " + PlayerPrefs.GetInt("LemonScore").ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!StartPlaying)
        {
            if(Input.anyKeyDown)
            {
                StartPlaying = true;
                TheBeat.HasStarted = true;
                JudgeText.text = "";
                ComboText.text = "0";
                TheMusic.Play();
            }
        }
    }

    public void EndGame()
    {
        PlayerPrefs.SetString("Songname",Name);
        PlayerPrefs.SetInt("Critical",CriticalHit);
        PlayerPrefs.SetInt("Perfect",PerfectHit);
        PlayerPrefs.SetInt("Good",GoodHit);
        PlayerPrefs.SetInt("Bad",BadHit);
        PlayerPrefs.SetInt("Miss",MissHit);
        PlayerPrefs.SetInt("Score",CurrentScore);


        SceneManager.LoadScene("End");
    }
    public void NoteMissed()
    {

        Debug.Log("MissedNote");
        CurrentCombo = 0;
        JudgeText.text = "Miss";
        JudgeText.color = new Color32(60, 60, 60, 255);
        ComboText.text = "" + CurrentCombo;
        MissHit++;
        
    }
    public void NoteBadHit()
    {
        Debug.Log("Bad");
        CurrentScore += (ScorePerNote * 3 / 10);
        CurrentCombo=0;

        ScoreText.text = "Score: " + CurrentScore;
        JudgeText.text = "Bad";
        JudgeText.color = new Color32(80, 10, 0, 255);
        ComboText.text = "" + CurrentCombo;
        ScorePerNote = 100 + (CurrentCombo / 10);
        BadHit++;
    }
    public void NoteGoodHit()
    {
        Debug.Log("Good");
        CurrentScore += (ScorePerNote * 8/10);
        CurrentCombo ++;

        ScoreText.text = "Score: " + CurrentScore;
        JudgeText.text = "Good";
        JudgeText.color = new Color32(0, 100, 0, 255);
        ComboText.text = "" + CurrentCombo;
        ScorePerNote = 100 + (CurrentCombo / 10);
        GoodHit++;
    }
    public void NotePerfectHit()
    {
        Debug.Log("Perfect");
        CurrentScore += ScorePerNote;
        CurrentCombo ++;

        ScoreText.text = "Score: " + CurrentScore;
        JudgeText.text = "Perfect";
        JudgeText.color = new Color32(255, 255, 0, 200);
        ComboText.text = "" + CurrentCombo;
        ScorePerNote = 100 + (CurrentCombo / 10);
        PerfectHit++;
    }
    public void NoteCriticalHit()
    {
        Debug.Log("Critical");
        CurrentScore += ScorePerNote;
        CurrentScore ++;
        CurrentCombo ++;

        ScoreText.text = "Score: " + CurrentScore;
        JudgeText.text = "Critical";
        JudgeText.color = new Color32(230, 130, 0, 200);
        ComboText.text = "" + CurrentCombo;
        ScorePerNote = 100 + (CurrentCombo / 10);
        CriticalHit++;
    }
}
