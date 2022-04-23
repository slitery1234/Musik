using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuaSuiYueChart : MonoBehaviour
{
    public ChartManager TheCM;
    public GameManager TheGM;
    public Beat TheBeat;
    public Summon ChartNote;
    bool ChartStart;
    float last_timer;

    // Start is called before the first frame update
    void Start()
    {
        ChartStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (TheGM.StartPlaying && !ChartStart)
        {
            ChartStart = true;
            last_timer = TheCM.Timer;
        }
        else if (TheGM.StartPlaying)
        {
            if(last_timer > TheCM.length+5)
            {
                TheGM.EndGame();
            }

            // Give up QQ

            if (last_timer < (TheCM.Timer - Time.deltaTime))
            {
                MakeChart(2, 1.7f);
                MakeChart(3, 1.9f);
                MakeChart(4, 2.1f);

                MakeChart(5, 2.6f);
                MakeChart(6, 3.3f);
                MakeChart(5, 4.1f);
                MakeChart(6, 4.9f);
                MakeChart(8, 5.6f);

                MakeChart(8, 7.3f);
                MakeChart(7, 7.4f);
                MakeChart(6, 7.5f);

                MakeChart(4, 8.1f);
                MakeChart(3, 8.2f);
                MakeChart(2, 8.3f);

                MakeChart(3, 9f);

                MakeChart(4, 9.4f);
                MakeChart(5, 9.8f);
                MakeChart(6, 10.2f);
                MakeChart(7, 10.6f);
                MakeChartBoth(4, 8, 11.4f);

                MakeChart(1, 12.2f);
                MakeChart(2, 12.6f);
                MakeChart(3, 13f);
                MakeChart(4, 13.4f);
                MakeChartBoth(1, 5, 13.8f);

                MakeChartBoth(7, 8, 15.3f);
                MakeChart(7, 16.3f);
                MakeChart(6, 16.6f);
                MakeChart(5, 17f);

                MakeChart(6, 17.5f);
                MakeChart(5, 17.9f);
                MakeChart(1, 18.3f);
                MakeChart(2, 18.7f);
                MakeChart(3, 19.1f);
                MakeChart(4, 19.5f);
                MakeChart(5, 19.9f);
                MakeChart(6, 20.3f);

                MakeChartBoth(7, 8, 21.3f);
                MakeChartBoth(1, 2, 22f);
                MakeChart(2, 22.9f);
                MakeChart(3, 23.3f);
                MakeChart(4, 23.7f);
                MakeChart(4, 24.1f);
                MakeChart(3, 24.5f);
                MakeChart(2, 24.9f);
                MakeChart(1, 25.3f);

                
                MakeChart(1, 25.8f);
                MakeChart(2, 26f);
                MakeChart(3, 26.2f);
                MakeChart(4, 26.4f);
                MakeChartBoth(5, 8, 26.8f);

                MakeChart(1, 28.4f);

                MakeChart(1, 29.4f);
                MakeChart(8, 29.8f);
                MakeChart(7, 30.2f);
                
                MakeChart(8, 31f);
                MakeChart(6, 31.4f);
                MakeChart(7, 31.8f);
                MakeChart(5, 32.2f);
                MakeChart(6, 32.6f);
                MakeChart(4, 33f);
                MakeChart(2, 33.4f);

                MakeChart(1, 34.4f);
                MakeChart(2, 34.8f);
                MakeChart(3, 35.2f);
                
                MakeChart(1, 36f);
                MakeChart(2, 36.2f);
                MakeChart(3, 36.4f);
                MakeChart(4, 36.6f);
                MakeChart(5, 36.8f);
                MakeChart(6, 37f);
                MakeChart(7, 37.2f);
                MakeChart(8, 37.4f);
                
                MakeChartBoth(1, 5, 38.8f);
                MakeChartBoth(2, 6, 39f);
                
                MakeChart(8, 39.6f);
                MakeChart(7, 39.8f);
                MakeChart(6, 40f);
                MakeChart(4, 40.4f);
                MakeChart(3, 40.6f);
                MakeChart(2, 40.8f);

                MakeChartBoth(1, 5, 41.2f);
                MakeChartBoth(1, 5, 41.4f);

                MakeChartBoth(1, 5, 42.2f);
                
                MakeChart(1, 43f);
                MakeChart(3, 43.4f);
                MakeChart(5, 43.8f);
                MakeChart(7, 44.2f);

                MakeChart(8, 45f);
                MakeChart(6, 45.4f);
                MakeChart(4, 45.8f);
                MakeChart(2, 46.2f);

                MakeChart(1, 47.2f);
                MakeChart(3, 47.6f);
                MakeChart(5, 48f);
                MakeChart(7, 48.4f);

                MakeChartBoth(8, 1,49.2f);
                MakeChartBoth(7, 2,49.6f);
                MakeChartBoth(6, 3,50f);
                MakeChartBoth(5, 4,50.4f);
                MakeChartBoth(6, 3,50.8f);
                MakeChartBoth(7, 2,51.2f);
                
                MakeChartBoth(6, 3,53.6f);
                MakeChartBoth(5, 4,53.6f);

                MakeChart(2, 54f);
                MakeChart(3, 54.4f);
                MakeChart(8, 55.4f);
                MakeChart(7, 55.6f);
                MakeChart(6, 56.2f);

                MakeChartBoth(5, 1,56.9f);
                MakeChartBoth(6, 2,57.3f);
                MakeChartBoth(7, 3,57.7f);
                MakeChart(4, 58.5f);
                MakeChart(3, 58.7f);
                MakeChart(2, 59.3f);

                MakeChartBoth(5, 1,60f);
                MakeChartBoth(6, 2,60.4f);
                MakeChartBoth(7, 3,60.8f);
                
                MakeChart(4, 61.2f);
                MakeChart(5, 61.6f);
                MakeChart(6, 62f);
                MakeChart(7, 62.4f);
                MakeChart(8, 62.8f);
                MakeChart(7, 63.2f);
                MakeChart(6, 63.6f);
                MakeChart(5, 64f);

                MakeChartBoth(1, 2,64.2f);
                MakeChartBoth(3, 4,64.2f);
                MakeChartBoth(1, 2,64.6f);
                MakeChartBoth(3, 4,64.6f);
                MakeChartBoth(1, 2,64.8f);
                MakeChartBoth(3, 4,64.8f);
                MakeChartBoth(1, 2,65.2f);
                MakeChartBoth(3, 4,65.2f);
                
                MakeChart(2, 65.6f);
                MakeChart(3, 66f);
                MakeChart(4, 66.4f);
                MakeChart(5, 66.8f);
                MakeChart(8, 67f);
                MakeChart(7, 67.2f);
                MakeChart(6, 67.4f);

                MakeChartBoth(1, 5,67.8f);
                MakeChart(2, 68.2f);
                MakeChart(3, 68.4f);
                MakeChart(2, 69f);

                MakeChart(3, 69.4f);
                MakeChart(4, 69.8f);
                MakeChart(5, 70.2f);

                MakeChart(6, 70.6f);
                MakeChart(5, 70.8f);
                MakeChart(6, 71.4f);

                MakeChart(5, 71.8f);
                MakeChart(4, 72.2f);
                MakeChart(3, 72.6f);
                MakeChart(2, 73f);
                MakeChart(1, 73.4f);
                MakeChart(2, 73.8f);

                MakeChartBoth(8, 4,74.2f);
                MakeChartBoth(7, 3,74.6f);
                MakeChartBoth(6, 2,75f);

                MakeChart(1, 75.4f);
                MakeChart(2, 75.6f);
                MakeChartBoth(4, 8,76f);

                MakeChart(1, 76.4f);
                MakeChartBoth(2, 7,77.2f);

                last_timer = TheCM.Timer;
            }
        }


    }
    public void MakeChart(int place, float time)
    {
        if( time < last_timer)
        {
            return;
        }
        if (TheCM.Timer > time)
        {
            SummonNote(place);
            return;
        }
        else
        {
        }
        
    }
    public void MakeChartBoth(int place1, int place2, float time)
    {
        if( time < last_timer)
        {
            return;
        }
        if (TheCM.Timer > time)
        {
            SummonNote(place1);
            SummonNote(place2);
            return;
        }
        else
        {
        }
    }
    public void SummonNote(int place)
    {
        if (place == 1)
        {
            ChartNote.SummonHit1();
        }
        else if (place == 2)
        {
            ChartNote.SummonHit2();
        }
        else if (place == 3)
        {
            ChartNote.SummonHit3();
        }
        else if (place == 4)
        {
            ChartNote.SummonHit4();
        }
        else if (place == 5)
        {
            ChartNote.SummonHit5();
        }
        else if (place == 6)
        {
            ChartNote.SummonHit6();
        }
        else if (place == 7)
        {
            ChartNote.SummonHit7();
        }
        else if (place == 8)
        {
            ChartNote.SummonHit8();
        }
        return;
    }

}
