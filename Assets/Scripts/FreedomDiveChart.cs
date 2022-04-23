using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreedomDiveChart : MonoBehaviour
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
                MakeChart(1,0.7f);
                MakeChart(1,0.95f);
                MakeChart(1,1.2f);

                MakeChart(1,1.8f);
                MakeChart(5,1.95f);
                MakeChart(2,2.1f);
                MakeChart(6,2.25f);
                MakeChart(3,2.4f);
                MakeChart(7,2.55f);
                MakeChart(8,2.7f);
                MakeChart(7,2.75f);
                MakeChart(6,2.8f);
                MakeChart(5,2.85f);

                MakeChartBoth(1,5,3.2f);
                MakeChartBoth(1,5,3.5f);

                MakeChart(5,3.7f);
                MakeChart(4,3.8f);
                MakeChart(5,3.9f);
                MakeChart(4,4.0f);
                MakeChart(5,4.1f);
                MakeChart(4,4.2f);
                MakeChart(5,4.3f);
                MakeChart(4,4.4f);
                MakeChart(5,4.5f);
                MakeChart(4,4.6f);
                MakeChart(5,4.7f);
                MakeChart(4,4.8f);
                MakeChart(3,4.9f);
                MakeChart(2,5.0f);

                MakeChart(1,5.15f);
                MakeChart(1,5.3f);

                MakeChart(1,5.5f);
                MakeChart(2,5.55f);
                MakeChart(3,5.6f);
                MakeChart(4,5.65f);

                MakeChart(8,5.7f);
                MakeChart(7,5.75f);
                MakeChart(6,5.8f);
                MakeChart(5,5.85f);

                MakeChart(1,6.0f);
                MakeChart(2,6.05f);
                MakeChart(3,6.1f);
                MakeChart(4,6.15f);

                MakeChart(8,6.2f);
                MakeChart(7,6.25f);
                MakeChart(6,6.3f);
                MakeChart(5,6.35f);

                MakeChart(8,6.5f);
                MakeChart(7,6.55f);
                MakeChart(6,6.6f);
                MakeChart(5,6.65f);
                MakeChart(4,6.7f);
                MakeChart(3,6.75f);
                MakeChart(2,6.8f);
                MakeChart(1,6.85f);

                MakeChartBoth(1,8,7.05f);
                
                MakeChart(1,7.35f);
                MakeChart(1,7.65f);
                MakeChart(1,7.95f);
                MakeChart(1,8.25f);
                MakeChart(1,8.55f);
                MakeChart(1,8.85f);
                MakeChart(1,9.15f);
                MakeChart(1,9.45f);
                
                MakeChart(5,9.75f);
                MakeChart(1,10.05f);
                MakeChart(5,10.35f);
                MakeChart(1,10.65f);
                MakeChart(5,10.95f);
                MakeChart(1,11.25f);
                MakeChart(2,11.4f);
                MakeChart(3,11.55f);
                MakeChart(1,11.85f);

                MakeChart(2,12.0f);
                MakeChart(8,12.3f);
                MakeChart(7,12.4f);
                MakeChart(6,12.5f);

                MakeChart(3,12.6f);
                MakeChart(5,12.9f);
                MakeChart(6,13.0f);
                MakeChart(7,13.1f);
                MakeChart(8,13.2f);

                MakeChart(8,13.3f);
                MakeChart(1,13.45f);
                MakeChart(7,13.6f);
                MakeChart(2,13.75f);
                MakeChart(6,13.9f);
                MakeChart(3,14.05f);
                MakeChart(5,14.2f);
                MakeChart(4,14.35f);
                MakeChart(3,14.5f);
                MakeChart(2,14.65f);
                
                MakeChart(1,14.8f);
                MakeChart(1,14.95f);
                MakeChart(2,15.1f);
                MakeChart(2,15.25f);
                MakeChart(3,15.4f);
                MakeChart(3,15.55f);
                MakeChart(4,15.7f);
                MakeChart(4,15.85f);
                
                MakeChart(8,16.25f);
                MakeChart(8,16.55f);
                MakeChart(7,16.65f);
                MakeChart(6,16.75f);
                MakeChart(7,17.15f);
                MakeChart(7,17.45f);
                MakeChart(6,17.55f);
                MakeChart(5,17.65f);

                MakeChartBoth(1,5,18.05f);
                MakeChartBoth(1,5,18.35f);
                MakeChartBoth(2,6,18.45f);
                MakeChartBoth(3,7,18.55f);
                MakeChartBoth(8,4,18.95f);
                MakeChartBoth(8,4,19.25f);
                MakeChartBoth(7,3,19.35f);
                MakeChartBoth(6,2,19.45f);
                MakeChartBoth(5,1,19.55f);

                MakeChartBoth(1,5,20f);
                MakeChartBoth(1,5,20.2f);

                MakeChart(1,20.6f);
                MakeChart(3,20.8f);
                MakeChart(5,21f);
                MakeChart(7,21.2f);
                MakeChart(8,21.4f);
                MakeChart(6,21.6f);
                MakeChart(4,21.8f);
                MakeChart(2,22f);
                MakeChart(1,22.2f);

                MakeChart(2,22.5f);
                MakeChart(3,22.8f);
                MakeChart(4,23.1f);
                MakeChart(5,23.4f);
                MakeChart(6,23.7f);
                MakeChart(7,24.0f);
                MakeChart(8,24.3f);
                
                MakeChart(1,24.6f);
                MakeChart(5,25.1f);
                MakeChart(8,25.6f);
                MakeChart(4,26.1f);
                MakeChart(2,26.6f);
                MakeChart(7,27.1f);
                MakeChart(6,27.6f);

                MakeChart(2,28.15f);
                MakeChart(3,28.25f);
                MakeChart(4,28.35f);
                MakeChart(5,28.45f);
                MakeChart(6,28.55f);
                MakeChart(7,28.65f);
                
                MakeChart(8,28.95f);
                MakeChart(7,29.25f);
                MakeChart(6,29.55f);
                MakeChart(5,29.85f);
                MakeChart(4,30.15f);
                MakeChart(3,30.45f);
                MakeChart(2,30.7f);
                MakeChart(3,30.9f);
                MakeChart(4,31.2f);
                MakeChart(5,31.5f);
                MakeChart(6,31.8f);
                MakeChart(7,32.1f);

                MakeChart(7,32.65f);

                MakeChart(1,33.05f);
                MakeChart(2,33.35f);
                MakeChart(3,33.65f);
                MakeChart(4,33.95f);

                MakeChart(5,34.25f);
                MakeChart(4,34.3f);
                MakeChart(3,34.35f);
                MakeChart(2,34.45f);
                MakeChart(1,34.5f);

                MakeChart(8,34.8f);
                MakeChart(6,35.1f);

                MakeChart(7,35.35f);
                MakeChart(3,35.65f);
                MakeChart(5,35.95f);
                MakeChart(2,36.25f);
                MakeChart(8,36.55f);
                MakeChart(1,36.85f);
                MakeChart(6,37.15f);
                MakeChart(4,37.45f);

                MakeChart(4,37.75f);
                MakeChart(5,37.85f);

                MakeChart(8,38.35f);
                MakeChart(7,38.6f);
                MakeChart(6,38.85f);
                MakeChart(5,39.1f);
                MakeChart(1,39.35f);
                MakeChart(2,39.6f);
                MakeChart(3,39.85f);
                MakeChart(4,40.1f);
                MakeChart(6,40.35f);
                MakeChart(7,40.45f);
                
                MakeChartBoth(1,8,40.55f);
                MakeChartBoth(2,7,40.85f);
                MakeChartBoth(3,6,41.15f);
                MakeChartBoth(4,5,41.45f);
                
                MakeChart(8,41.6f);
                MakeChart(4,41.9f);
                MakeChart(7,42.2f);
                MakeChart(3,42.5f);
                MakeChart(6,42.8f);
                MakeChart(2,43.1f);
                MakeChart(5,43.4f);
                MakeChart(1,43.7f);
                
                MakeChart(1,44f);
                MakeChart(1,44.3f);
                MakeChartBoth(1,2,44.55f);
                MakeChartBoth(2,3,44.8f);
                MakeChartBoth(3,4,45.05f);
                MakeChartBoth(4,5,45.3f);
                MakeChartBoth(5,6,45.55f);
                MakeChartBoth(5,6,45.8f);

                MakeChart(8,46.1f);
                MakeChart(8,46.4f);
                MakeChartBoth(8,7,46.65f);
                MakeChartBoth(7,6,46.9f);
                MakeChartBoth(6,5,47.15f);
                MakeChartBoth(5,4,47.4f);
                MakeChartBoth(4,3,47.65f);
                MakeChartBoth(4,3,47.9f);   
                
                MakeChartBoth(8,4,48.2f);
                MakeChartBoth(7,3,48.45f);
                MakeChartBoth(6,2,48.7f);
                MakeChartBoth(5,1,48.95f);
                MakeChart(1,49.25f);
                MakeChart(2,49.5f);
                MakeChart(3,49.75f);
                MakeChart(4,50f);
                MakeChartBoth(5,4,50.3f);
                MakeChartBoth(6,3,50.55f);
                MakeChartBoth(7,2,50.8f);
                MakeChartBoth(8,1,51.05f);

                MakeChart(8,51.35f);
                MakeChart(7,51.4f);
                MakeChart(6,51.45f);
                MakeChart(5,51.5f);
                MakeChart(4,51.55f);
                MakeChart(3,51.6f);
                MakeChart(2,51.65f);
                MakeChart(1,51.7f);

                MakeChartBoth(3,5,51.95f);
                MakeChartBoth(4,6,52.2f);
                
                MakeChartBoth(8,4,52.5f);
                MakeChartBoth(8,4,52.8f);
                MakeChart(7,53.05f);
                MakeChart(7,53.3f);
                MakeChart(6,53.55f);
                MakeChart(6,53.8f);
                MakeChart(5,54.05f);
                MakeChart(5,54.3f);
                
                MakeChartBoth(1,5,54.6f);
                MakeChartBoth(1,5,54.9f);
                MakeChartBoth(1,6,55.15f);
                MakeChartBoth(1,7,55.45f);
                MakeChartBoth(1,8,55.75f);
                MakeChartBoth(1,7,56.05f);
                MakeChartBoth(1,6,56.35f);
                MakeChartBoth(1,5,56.65f);

                MakeChart(5,56.9f);
                MakeChart(5,57.2f);
                MakeChart(6,57.45f);
                MakeChart(6,57.75f);
                MakeChartBoth(3,7,58.05f);
                MakeChartBoth(3,7,58.35f);
                MakeChartBoth(4,8,58.65f);
                MakeChartBoth(4,8,58.95f);

                MakeChart(8,59.15f);
                MakeChart(7,59.25f);
                MakeChart(6,59.35f);
                MakeChart(5,59.45f);
                MakeChartBoth(4,5,59.65f);
                MakeChartBoth(3,6,59.75f);
                MakeChartBoth(2,7,59.85f);
                MakeChartBoth(1,8,59.95f);
                MakeChart(8,60.15f);
                MakeChart(4,60.25f);
                MakeChart(7,60.35f);
                MakeChart(3,60.45f);
                MakeChart(6,60.55f);
                MakeChart(2,60.65f);
                MakeChart(5,60.75f);
                MakeChart(1,60.85f);

                MakeChart(1,61.15f);
                MakeChartBoth(1,6,61.3f);
                MakeChart(2,61.45f);
                MakeChartBoth(2,5,61.6f);
                MakeChart(3,61.75f);
                MakeChartBoth(3,8,61.9f);
                MakeChart(4,62.05f);
                MakeChartBoth(4,7,62.2f);

                MakeChart(5,62.35f);
                MakeChartBoth(5,4,62.5f);
                MakeChart(6,62.65f);
                MakeChartBoth(6,2,62.8f);
                MakeChart(7,62.95f);
                MakeChartBoth(7,3,63.1f);
                MakeChart(8,63.25f);
                MakeChartBoth(8,1,63.4f);
                
                MakeChart(8,63.55f);
                MakeChart(7,63.7f);
                MakeChart(6,63.85f);
                MakeChart(5,64f);
                MakeChart(4,64.15f);
                MakeChart(4,64.3f);
                MakeChart(3,64.45f);
                MakeChart(3,64.6f);

                MakeChart(1,64.75f);
                MakeChart(2,64.9f);
                MakeChart(3,65.05f);
                MakeChart(4,65.2f);
                MakeChart(5,65.35f);
                MakeChart(6,65.5f);
                  
                MakeChartBoth(8,1,65.8f);
                MakeChartBoth(7,1,66.1f);
                MakeChartBoth(6,2,66.4f);
                MakeChartBoth(5,2,66.7f);
                MakeChartBoth(4,3,67f);
                MakeChartBoth(3,4,67.3f);
                MakeChart(5,67.55f);
                MakeChart(6,67.85f);
                MakeChart(7,68.05f);
                MakeChart(8,68.35f);
                MakeChartBoth(8,4,68.65f);
                MakeChartBoth(7,3,68.95f);
                MakeChartBoth(1,5,69.25f);
                MakeChartBoth(1,5,69.55f);
                
                MakeChart(5,69.8f);
                MakeChart(6,70.1f);
                MakeChart(7,70.4f);
                MakeChart(8,70.7f);

                MakeChart(7,70.8f);
                MakeChart(6,70.9f);
                MakeChart(5,71f);
                MakeChart(4,71.1f);
                MakeChartBoth(2,7,71.35f);
                MakeChartBoth(1,8,71.65f);

                MakeChart(3,71.9f);
                MakeChart(8,72.15f);
                MakeChart(1,72.4f);
                MakeChart(6,72.65f);
                MakeChart(2,72.9f);
                MakeChart(5,73.15f);
                MakeChart(4,73.4f);
                MakeChart(7,73.65f);
                MakeChart(7,73.9f);
                MakeChart(3,74.15f);
                
                MakeChart(1,74.4f);

                MakeChart(1,75.45f);
                MakeChart(2,75.55f);

                MakeChart(8,75.85f);
                MakeChart(7,76.45f);
                MakeChart(6,76.75f);

                MakeChartBoth(8,4,77.4f);
                MakeChartBoth(7,3,77.65f);
                MakeChartBoth(6,2,77.9f);
                MakeChartBoth(5,1,78.15f);

                MakeChartBoth(1,2,78.45f);
                MakeChartBoth(3,4,78.45f);
                MakeChartBoth(5,6,78.45f);
                MakeChartBoth(7,8,78.45f);
 

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
