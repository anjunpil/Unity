using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    public int age { get; set; }
    public int hp { get; set; }
    public string name { get; set; }

    //enemy Ŭ���� ������
    public Enemy()
    {
        age = 10;
        hp = 100;
        name = "hero";
    }
    public void Hit()
    {
        int damage = 10;
        hp -= damage;

        shout();
    }
    
    protected virtual void shout()
    {

    }

    
}