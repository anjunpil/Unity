using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��������Ʈ�� �Լ��� ���� ����
//� ��Ȳ�� �����Ҷ� ��������Ʈ �̺�Ʈ�� �Բ� ����

delegate void EventHandler(Color color);

class OrcPrams
{
    public event EventHandler eventHandler;

    int _hp = 100;

    public int hp {
        get { return _hp; }
        set {
            _hp = value;
            //50���Ϸ� ������ �� ���� �������� �ٲٴ� �̺�Ʈ �߻�
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
