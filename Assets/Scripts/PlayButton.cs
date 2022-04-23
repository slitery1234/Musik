using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void clickPlay()
    {
        SceneManager.LoadScene("Select");
    }
    public void clickQuit()
    {
        Application.Quit();
    }
    public void clickHuaSuiYue()
    {
        SceneManager.LoadScene("HuaSuiYue");
    }
    public void clickLemon()
    {
        SceneManager.LoadScene("Lemon");
    }
    public void clickFreedomDive()
    {
        SceneManager.LoadScene("FreedomDive");
    }
    public void clickTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void clickReset()
    {
        PlayerPrefs.SetInt("HuaSuiYueScore",0);
        PlayerPrefs.SetInt("FreedomDiveScore",0);
        PlayerPrefs.SetInt("LemonScore",0);
    }
}
