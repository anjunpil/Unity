using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : Enemy
{
    
    protected override void shout()
    {
        //base는 부모 enemy class
        base.shout();

        //monobehavior를 상속하지 않고 enemy를 상속하므로 print나 start update등을 사용할 수 없음 
        //그래서 debug를 사용
        Debug.Log("I'm monster,,");
    }

}
