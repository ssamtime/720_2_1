using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    public GameObject origin; // ���� ���̵Ǵ� ���ӿ�����Ʈ
    public float speed = 1.0f; //ȸ���ӵ�
    
   
    void Update()
    {

        transform.RotateAround(
            origin.transform.position,//ȸ�������̵Ǵ� ������Ʈ
            Vector3.down,//ȸ����
            speed * Time.deltaTime);//ȸ���ӵ�
    }
}
