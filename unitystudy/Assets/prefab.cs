using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�� ������ ������ ������Ʈ ��ȯ�� ���
//������Ƽ���� ����Ǿ��� �� ������ �������� �ʾƵ� ��


public class prefab : MonoBehaviour
{
    public GameObject Prefab;
    public Transform Parent;
    
    // Start is called before the first frame update
    void Start()
    {
        //�ν��Ͻ� ����
        GameObject MyInstance = Instantiate(Prefab);
        //postion
        //MyInstance.transform.position = Parent + new Vector3(0, 1, 0);
        //component ����
        //MyInstance.GetComponent<MyChild>().Init();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class MyChild : MonoBehaviour{
    string name;
    void Init()
    {
        name = "Init";
    }
    }
