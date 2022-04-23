using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemonChart : MonoBehaviour
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
            // Give up QQ

            if (last_timer < (TheCM.Timer - Time.deltaTime))
            {
                MakeChart(1,1.0f);
                MakeChart(3,1.6f);
                MakeChart(5,2.2f);
                MakeChart(7,2.8f);

                MakeChart(8,3.4f);
                MakeChart(7,3.7f);

                MakeChart(4,5.3f);
                MakeChartBoth(4,8,5.9f);
                MakeChart(2,6.5f);
                MakeChartBoth(1,5,7.3f);
                MakeChart(2,7.9f);
                MakeChartBoth(1,8,8.5f);
                MakeChart(4,9.2f);

                MakeChart(8,10.7f);
                MakeChart(7,11.9f);

                MakeChart(1,13.1f);
                MakeChart(2,13.7f);
                MakeChart(3,14.3f);
                MakeChart(4,14.9f);
                MakeChart(5,15.5f);

                MakeChart(2,16.1f);
                MakeChartBoth(1,8,16.7f);
                MakeChart(5,17.4f);
                MakeChart(3,18.2f);

                MakeChart(1,19f);

                MakeChart(1,19.4f);
                MakeChart(1,19.55f);
                MakeChart(1,20.05f);
                MakeChart(1,20.2f);

                MakeChart(7,25.2f);
                MakeChart(8,26.4f);
                MakeChart(1,27.3f);
                MakeChart(2,27.9f);
                MakeChart(3,28.5f);

                MakeChart(8,29.6f);
                MakeChart(8,29.9f);
                MakeChart(7,30.8f);
                MakeChart(6,31.7f);
                MakeChart(5,32.6f);
                MakeChart(4,33.5f);
                MakeChart(4,33.8f);
                MakeChart(4,34.1f);

                MakeChart(1,35f);
                MakeChart(5,36.2f);

                MakeChart(8,37.4f);
                MakeChart(7,38f);
                MakeChart(6,38.6f);
                MakeChart(5,39.2f);
                MakeChart(4,39.5f);
                
                MakeChart(1,40.4f);
                MakeChart(2,41f);
                MakeChart(3,41.6f);
                MakeChart(4,42.2f);
                MakeChart(5,43.1f);
                MakeChart(6,43.7f);
                MakeChart(7,44.3f);
                MakeChart(8,44.9f);
                MakeChart(8,45.1f);
                
                MakeChart(8,46.6f);
                MakeChartBoth(4,8,47.6f);
                MakeChart(8,48f);
                MakeChartBoth(4,8,48.7f);
 
                MakeChart(4,49.4f);
                MakeChartBoth(4,8,50.2f);
                MakeChart(4,50.6f);
                MakeChartBoth(4,8,51.3f);
                
                MakeChart(7,52.6f);
                MakeChart(5,53.2f);
                MakeChart(3,53.8f);
                MakeChart(1,54.4f);

                MakeChart(1,54.8f);

                MakeChart(1,55.6f);
                MakeChart(2,55.8f);
                MakeChart(3,56f);
                
                MakeChart(8,56.8f);
                MakeChart(6,57.2f);
                MakeChart(1,57.7f);
                MakeChart(2,58.3f);
                MakeChart(3,58.9f);

                MakeChart(1,59.5f);
                MakeChart(3,59.9f);
                MakeChart(8,60.4f);
                MakeChart(7,61.0f);
                MakeChart(6,61.6f);

                MakeChart(3,62.4f);
                MakeChart(5,62.8f);
                MakeChart(6,63.2f);
                MakeChart(7,63.8f);
                MakeChart(8,64.4f);

                MakeChartBoth(4,8,65.3f);
                MakeChartBoth(3,7,65.9f);
                MakeChartBoth(2,6,66.5f);
                MakeChartBoth(1,5,67.1f);

                MakeChart(7,67.9f);
                MakeChart(5,68.3f);
                MakeChart(3,68.8f);
                MakeChart(4,69.2f);
                MakeChart(5,69.8f);

                MakeChart(6,70.5f);
                MakeChart(7,71.1f);

                MakeChart(8,71.5f);
                MakeChart(7,72.1f);
                MakeChart(6,72.7f);
                
                MakeChart(5,74.3f);
                MakeChart(6,74.6f);
                MakeChart(7,74.9f);
                MakeChart(8,75.2f);
                MakeChart(4,75.5f);
                MakeChart(3,75.8f);
                MakeChart(2,76.1f);
                MakeChart(1,76.4f);

                MakeChart(1,77f);
                MakeChart(3,77.6f);
                MakeChart(5,78.2f);
                
                MakeChart(1,79.1f);
                MakeChart(2,79.4f);
                MakeChart(3,79.7f);
                MakeChart(4,80f);
                MakeChart(8,80.3f);
                MakeChart(7,80.6f);
                MakeChart(6,80.9f);
                MakeChart(5,81.2f);

                MakeChart(2,81.8f);
                MakeChart(4,82.4f);
                MakeChart(6,83f);
                MakeChart(8,83.6f);

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
