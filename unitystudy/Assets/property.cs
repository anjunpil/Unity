using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//monobehaviour �ϳ��� Ŭ������
public class property : MonoBehaviour
{
    //propert�� get ,set ����� ���ŷο��� ���̱� ���� ��� 
    // Start is called before the first frame update
    private int remainedHP=100;

    //get, set ������ �ȿ� �ƹ��͵� �Ⱦ��� ��� ������Ƽ ��ü�� �����
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
                print("�÷��̾ ����߽��ϴ�");
            }
            else
            {
                    
                print(remainedHP);
                print("�� ���ҽ��ϴ�");
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

