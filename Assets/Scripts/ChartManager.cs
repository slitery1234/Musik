using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChartManager : MonoBehaviour
{
    public GameManager TheGM;
    public float length;
    public float StartTime;
    public float NowTime;
    public float Timer;
    public bool ChartStart;

    
    // Start is called before the first frame update
    void Start()
    {
        ChartStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(TheGM.StartPlaying && !ChartStart)
        {
            length = TheGM.TheMusic.clip.length;
            StartTime = Time.time;
            ChartStart = true;
        }
        
        NowTime = Time.time;
        Timer = NowTime-StartTime;

        if(TheGM.StartPlaying && (Timer > length))
        {
            //End
            TheGM.EndGame();
        }
        
    }
}
