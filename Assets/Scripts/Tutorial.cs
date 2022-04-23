using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public Text JudgeText;    
    int count;
    public KeyCode A;
    public KeyCode S;
    public KeyCode D;
    public KeyCode F;
    public KeyCode H;
    public KeyCode J;
    public KeyCode K;
    public KeyCode L;
    public KeyCode Back;
    // Start is called before the first frame update
    void Start()
    {
        JudgeText.text = "Press A as the first place";
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(count == 0 && Input.GetKeyDown(A))
        {
            JudgeText.text = "Press S as the second place";   
            count = 1;
        }
        else if(count == 1 && Input.GetKeyDown(S))
        {
            JudgeText.text = "Press D as the third place";
            count = 2;           
        }
        else if(count == 2 && Input.GetKeyDown(D))
        {
            JudgeText.text = "Press F as the fourth place";
            count = 3;           
        }
        else if(count == 3 && Input.GetKeyDown(F))
        {
            JudgeText.text = "Press H as the fifth place";
            count = 4;           
        }
        else if(count == 4 && Input.GetKeyDown(H))
        {
            JudgeText.text = "Press J as the sixth place";
            count = 5;           
        }
        else if(count == 5 && Input.GetKeyDown(J))
        {
            JudgeText.text = "Press K as the seventh place";
            count = 6;           
        }
        else if(count == 6 && Input.GetKeyDown(K))
        {
            JudgeText.text = "Press L as the eighth place";
            count = 7;           
        }
        else if(count == 7 && Input.GetKeyDown(L))
        {
            JudgeText.text = "Press Backspace to the Selectmenu";
            count = 8;           
        }
        else if(count == 8 && Input.GetKeyDown(Back))
        {
            SceneManager.LoadScene("Select");
        }
    }
}
