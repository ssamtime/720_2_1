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
            //AddForce : ������Ʈ�� ������ ���� ���ϴ� �Լ�
            rigid.AddForce(new Vector3(0, 200, 0));
            condition = false;
        }
    }

    //OnCollisionEnter: �������� �浹�� ���� �� ȣ��Ǵ� �Լ�
    private void OnCollisionEnter(Collision collision)
    {
        condition = true;
    }
    //OnCollisionStay: �浹�� �ϰ� ���� ��
    private void OnCollisionStay(Collision collision)
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
    //OnCollisionExit: �浹�� ����� �� ȣ��
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
