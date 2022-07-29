using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observe : MonoBehaviour
{
    public GameObject target;


    private void Update()
    {
        //�Ÿ��� 5���������� ����� �ٶ󺸰�
        if(Vector3.Distance(transform.position,target.transform.position)<=5)
        {
            transform.LookAt(target.transform);
        }
        else// �׷����ʴٸ� ȸ����
        {
            transform.rotation = Quaternion.Euler(15, 90, 0);
        }
    }
}
