using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    bool condition;
    public float speed;

    Rigidbody rigid;
    Vector3 direction;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space)&& condition ==true) 
        {
            //AddForce : 오브젝트에 일정한 힘을 가하는 함수
            rigid.AddForce(new Vector3(0, 200, 0));
            condition = false;
        }
    }

    //OnCollisionEnter: 물리적인 충돌을 했을 때 호출되는 함수
    private void OnCollisionEnter(Collision collision)
    {
        condition = true;
    }
    //OnCollisionStay: 충돌을 하고 있을 때
    private void OnCollisionStay(Collision collision)
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
    //OnCollisionExit: 충돌을 벗어났을 때 호출
    private void OnCollisionExit(Collision collision)
    {
        condition = false;
        transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }

    private void FixedUpdate()
    {
        rigid.MovePosition(rigid.position + direction.normalized*speed*Time.deltaTime);
    }
}
