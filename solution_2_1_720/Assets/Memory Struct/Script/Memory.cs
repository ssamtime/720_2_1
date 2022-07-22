using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    protected int health; //public: 외부에서도 접근가능
    protected int attack; //private : 나자신만 접근가능
    public string name; //protected: 나 자신과 상속하고 있는 클래스까지만 접근가능

    public void Information()
    {
        print(health);
        print(attack);
        print(name);
    }
}
public class Memory : Monster
{
    //코드영역: 프로그램이 실행되는 코드들이 저장되는 영역
    //데이터영역: 전역변수와 정적변수가 저장되는 영역
    //힙영역: 동적으로 새성한 메모리를 관리하는 영역, First in First Out
    //스택영역: 지역변수와 함수의 매개변수가 저장되는 영역,Last in First Out

    public int value = 100;
    void Start() 
    {
        health = 10;
        attack = 20;
        Information();
        
        int value = 250;
        value = 100;
        int area = 500; //함수안에서 생성되며 함수를 벗어나면 소멸하는 지역변수.
    }
    private void Update()
    {
        Move();
        //Calculator(1,2);
        print(add(10,20));
    }
    private void Move() //사용자지정함수는 호출해줘야댐
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
