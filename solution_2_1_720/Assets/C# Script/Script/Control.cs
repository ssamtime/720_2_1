using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public int hp =0;
    public string name1 = "shiver";
    public float height = 175.6f;
    public char bloodType = 'a';


    // Start is called before the first frame update
    void Start()
    {   
        //���ӿ�����Ʈ�� �Ӽ��� �ʱ�ȭ �� �� ���.
        hp = 300;
        name1 = "asdf";
     
        print(hp);
        print(name1);
        print(height);
        print(bloodType);

    }

    // Update is called once per frame
    void Update()
    {
        //���ӿ�����Ʈ�� �Է��̳� ��ġ�̵��� �� �� ���.
    }
}
