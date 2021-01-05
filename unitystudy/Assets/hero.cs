using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour
{
    public GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject obj in enemies)
        {
            obj.GetComponent<Renderer>().material.color = Color.black;
        }
        for (int i = 0; i < enemies.Length; i++)
            enemies[i].GetComponent<Renderer>().material.color = Color.black;
        print(GetComponent<Renderer>().material.color);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
