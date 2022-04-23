using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summon : MonoBehaviour
{
    public GameObject Note1;
    public GameObject Note2;
    public GameObject Note3;
    public GameObject Note4;
    public GameObject Note5;
    public GameObject Note6;
    public GameObject Note7;
    public GameObject Note8;

    // Start is called before the first frame update
    void Start()
    {
        //SummonHit1();
        //SummonHit2();
        //SummonHit5();
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    public void SummonHit1()
    {
        Instantiate(Note1,new Vector3(-3.5f,7.5f,0f),
        Note1.transform.rotation);
        return;
    }
    public void SummonHit2()
    {
        Instantiate(Note2,new Vector3(-2.5f,7.5f,0f),
        Note2.transform.rotation);
        return;
    }
    public void SummonHit3()
    {
        Instantiate(Note3,new Vector3(-1.5f,7.5f,0f),
        Note3.transform.rotation);
        return;
    }
    public void SummonHit4()
    {
        Instantiate(Note4,new Vector3(-0.5f,7.5f,0f),
        Note4.transform.rotation);
        return;
    }
    public void SummonHit5()
    {
        Instantiate(Note5,new Vector3(0.5f,7.5f,0f),
        Note5.transform.rotation);
        return;
    }
    public void SummonHit6()
    {
        Instantiate(Note6,new Vector3(1.5f,7.5f,0f),
        Note6.transform.rotation);
        return;
    }
    public void SummonHit7()
    {
        Instantiate(Note7,new Vector3(2.5f,7.5f,0f),
        Note7.transform.rotation);
        return;
    }
    public void SummonHit8()
    {
        Instantiate(Note8,new Vector3(3.5f,7.5f,0f),
        Note8.transform.rotation);
        return;
    }
}