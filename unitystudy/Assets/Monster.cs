using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : Enemy
{
    
    protected override void shout()
    {
        //base�� �θ� enemy class
        base.shout();

        //monobehavior�� ������� �ʰ� enemy�� ����ϹǷ� print�� start update���� ����� �� ���� 
        //�׷��� debug�� ���
        Debug.Log("I'm monster,,");
    }

}
