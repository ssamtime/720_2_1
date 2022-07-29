using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observe : MonoBehaviour
{
    public GameObject target;


    private void Update()
    {
        //거리가 5보다작으면 대상을 바라보게
        if(Vector3.Distance(transform.position,target.transform.position)<=5)
        {
            transform.LookAt(target.transform);
        }
        else// 그렇지않다면 회전값
        {
            transform.rotation = Quaternion.Euler(15, 90, 0);
        }
    }
}
