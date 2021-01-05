using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCube : MonoBehaviour
{
    Enemy myself;


    public void SetParam(Enemy enemy)
    {
        myself = enemy;
    }
    // Start is called before the first frame update
    void Start()
    {
        //³ú
        Monster myMonster = new Monster();
        Animal myAnimal = new Animal();
        //¸öÃ¼
        GameObject monster = GameObject.Find("Monster");
        monster.GetComponent<EnemyCube>().Setparam(myMonster);

        GameObject animal = GameObject.Find("Animal");
        monster.GetComponent<EnemyCube>().Setparam(myAnimal);

    }
    
    public void Setparam(Enemy enemy)
    {
        myself = enemy;
    }
    private void OnMouseDown()
    {
        print("A");
        if (myself != null)
            {
            myself.Hit();
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
