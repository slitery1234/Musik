using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public bool CanPressed;
    public KeyCode keyToPress;
    public float ButtonPosY;    
    public GameManager TheGM;
    public Beat TheBeat;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    { 
        if(TheGM.StartPlaying)
        {
            gameObject.transform.position -= new Vector3(0f , TheBeat.bpm * Time.deltaTime , 0f);
        }
        
        if(Input.GetKeyDown(keyToPress))
        {
            if(CanPressed)
            {
                CanPressed = false;
                gameObject.SetActive(false);
                //GameManager.instance.NoteHit();
                if(Mathf.Abs(transform.position.y - ButtonPosY) > 0.25)
                {
                    GameManager.instance.NoteBadHit();
                }
                else if (Mathf.Abs(transform.position.y - ButtonPosY) > 0.2)
                {
                    GameManager.instance.NoteGoodHit();
                }
                else if (Mathf.Abs(transform.position.y - ButtonPosY) > 0.05)
                {
                    GameManager.instance.NotePerfectHit();
                }
                else
                {
                    GameManager.instance.NoteCriticalHit();
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            CanPressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator" && CanPressed == true)
        {
            CanPressed = false;
            GameManager.instance.NoteMissed();
            Destroy(gameObject);
        }
    }
}
