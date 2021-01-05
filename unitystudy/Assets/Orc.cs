using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//델리게이트는 함수에 대한 참조
//어떤 상황에 도달할때 델리게이트 이벤트도 함께 제공

delegate void EventHandler(Color color);

class OrcPrams
{
    public event EventHandler eventHandler;

    int _hp = 100;

    public int hp {
        get { return _hp; }
        set {
            _hp = value;
            //50이하로 내려갈 시 색을 빨강으로 바꾸는 이벤트 발생
            if (hp <= 50) eventHandler(Color.red);
            }
        }

}


public class Orc : MonoBehaviour
{

    void ChangeColor(Color color)
    {
        this.GetComponent<Renderer>().material.color = Color.red;
    }

    void ShowColor(Color color)
    {
        print(color);
    }

    OrcPrams orcPrams = new OrcPrams();

    // Start is called before the first frame update
    void Start()
    {
        orcPrams.eventHandler += new EventHandler(ChangeColor);
        orcPrams.eventHandler += new EventHandler(ShowColor);
    }
    private void OnMouseDown()
    {
        orcPrams.hp -= 10;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
