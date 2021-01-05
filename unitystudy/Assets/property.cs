using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//monobehaviour 하나의 클래스다
public class property : MonoBehaviour
{
    //propert는 get ,set 사용의 번거로움을 줄이기 위해 사용 
    // Start is called before the first frame update
    private int remainedHP=100;

    //get, set 접근자 안에 아무것도 안쓰는 경우 프로퍼티 자체를 사용함
    class enemy {
        public string name { get; set; }
        public int hp { get; set; }
        public int attack { get; set; }
        public float speed { get; set; }
    }



    public int Damage
    {
        get
        {
            return remainedHP;
        }
        set
        {
            if (remainedHP == 0)
            {
                print(remainedHP);
                print("플레이어가 사망했습니다");
            }
            else
            {
                    
                print(remainedHP);
                print("가 남았습니다");
            }
        }
    }
    private void OnMouseEnter()
    {
        remainedHP = remainedHP - 10;
    }
    enemy my;

    void Start()
    {
       my = new enemy();
        my.name = "hero";
        my.hp = 100;
        my.speed = 10.0f;
        my.attack = 5;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

