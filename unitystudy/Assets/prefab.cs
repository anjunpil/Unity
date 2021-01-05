using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//각 씬마다 동일한 오브젝트 소환시 사용
//프로퍼티값이 변경되었을 때 일일이 수정하지 않아도 됨


public class prefab : MonoBehaviour
{
    public GameObject Prefab;
    public Transform Parent;
    
    // Start is called before the first frame update
    void Start()
    {
        //인스턴스 형성
        GameObject MyInstance = Instantiate(Prefab);
        //postion
        //MyInstance.transform.position = Parent + new Vector3(0, 1, 0);
        //component 접근
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
