using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    protected int health; //public: �ܺο����� ���ٰ���
    protected int attack; //private : ���ڽŸ� ���ٰ���
    public string name; //protected: �� �ڽŰ� ����ϰ� �ִ� Ŭ���������� ���ٰ���

    public void Information()
    {
        print(health);
        print(attack);
        print(name);
    }
}
public class Memory : Monster
{
    //�ڵ念��: ���α׷��� ����Ǵ� �ڵ���� ����Ǵ� ����
    //�����Ϳ���: ���������� ���������� ����Ǵ� ����
    //������: �������� ������ �޸𸮸� �����ϴ� ����, First in First Out
    //���ÿ���: ���������� �Լ��� �Ű������� ����Ǵ� ����,Last in First Out

    public int value = 100;
    void Start() 
    {
        health = 10;
        attack = 20;
        Information();
        
        int value = 250;
        value = 100;
        int area = 500; //�Լ��ȿ��� �����Ǹ� �Լ��� ����� �Ҹ��ϴ� ��������.
    }
    private void Update()
    {
        Move();
        //Calculator(1,2);
        print(add(10,20));
    }
    private void Move() //����������Լ��� ȣ������ߴ�
    {
        transform.position += new Vector3(1, 1, 0)*Time.deltaTime;
    }
    private void Calculator(int x,int y )
    {
        int temp = y + x;
        print(temp);
    }
    private int add(int x,int y)
    {
        return x+y;
    }
}
