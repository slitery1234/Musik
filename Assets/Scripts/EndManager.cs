using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Text SongName;
    public Text Miss;
    public Text Bad;
    public Text Good;
    public Text Perfect;
    public Text Critical;
    public Text Score;
    public KeyCode KeyToPress;
    void Start()
    {
        SongName.text = PlayerPrefs.GetString("Songname");
        Miss.text = PlayerPrefs.GetInt("Miss").ToString();
        Bad.text = PlayerPrefs.GetInt("Bad").ToString();
        Good.text = PlayerPrefs.GetInt("Good").ToString();
        Perfect.text = PlayerPrefs.GetInt("Perfect").ToString();
        Critical.text = PlayerPrefs.GetInt("Critical").ToString();
        Score.text = PlayerPrefs.GetInt("Score").ToString();

        if(PlayerPrefs.GetString("Songname") == "HuaSuiYue" && PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("HuaSuiYueScore"))
        {
            PlayerPrefs.SetInt("HuaSuiYueScore",PlayerPrefs.GetInt("Score") );
        }
        else if(PlayerPrefs.GetString("Songname") == "FreedomDive" && PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("FreedomDiveScore"))
        {
            PlayerPrefs.SetInt("FreedomDiveScore",PlayerPrefs.GetInt("Score") );
        }
        else if(PlayerPrefs.GetString("Songname") == "Lemon" && PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("LemonScore"))
        {
            PlayerPrefs.SetInt("LemonScore",PlayerPrefs.GetInt("Score") );
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyToPress))
        {
            SceneManager.LoadScene("Select");
        }
    }
}
