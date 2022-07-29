using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public Animator animator;
    public GameObject window;


    // Update is called once per frame
    void Update()
    {
        //���ϸ����� ��Ʈ�ѷ����� ���� �ִϸ����� ������ �̸��� "Close"���
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Close") )

        {
            //���� �ִϸ��̼��� ���൵�� 1���� ũ�ų� ���ٸ� window������Ʈ�� ��Ȱ��ȭ.
            if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime>=1)
            {
                window.SetActive(false);
            }
        }
    }
    public void Close()
    {
        animator.SetTrigger("Close");
    }
    public void PopUpOpen()
    {
        window.SetActive(true);
    }
}
