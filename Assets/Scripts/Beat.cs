using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour
{
    public float bpm;
    public bool HasStarted;

    // Start is called before the first frame update
    void Start()
    {
        bpm = bpm / 60f;
    }

    // Update is called once per frame
    void Update()
    {
         if(!HasStarted)
        {
            /* 
            if(Input.anyKeyDown)
            {
                HasStarted = true;
            }*/       
            
        }
        else
        {   
                    
        }
    }
}
