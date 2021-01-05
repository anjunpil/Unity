using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUpdate : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
        Debug.Log("FixedUpdate Time.FixedDeltatime"+ Time.fixedDeltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("UpDate");
        Debug.Log(Time.deltaTime);
    }
    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
        Debug.Log(Time.deltaTime);
    }
}
