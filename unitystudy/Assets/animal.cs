using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : Enemy
{
    protected virtual void shout()
    {
        Debug.Log("I'm animal......");
    }
}
