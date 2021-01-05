using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Changescene : MonoBehaviour
{
    public void SceneChange1()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("SampleScene 1");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
