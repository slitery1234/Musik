using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour
{
    public KeyCode KeyToPress;
    public KeyCode KeyToPress2;
    public KeyCode ToMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyToPress))
        {
            Application.Quit();
        }
        if(Input.GetKeyDown(KeyToPress2))
        {
            SceneManager.LoadScene("Select");
        }
        if(Input.GetKeyDown(ToMenu))
        {
            SceneManager.LoadScene("ZMainMenu");
        }
    }
}
