using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    public GameObject origin; // 기준 축이되는 게임오브젝트
    public float speed = 1.0f; //회전속도
    
   
    void Update()
    {

        transform.RotateAround(
            origin.transform.position,//회전기준이되는 오브젝트
            Vector3.down,//회전축
            speed * Time.deltaTime);//회전속도
    }
}
