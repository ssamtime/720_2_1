using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public int age;
    public string name2;

void Start()
    {
        Animal dog = new Dog();
        Animal cat = new Cat();
        Animal duck = new Duck();

        dog.Sound();
        cat.Sound();
        duck.Sound();
    }

    public virtual void Sound()
    {
        Debug.Log("匡澜家府");
    }

    public void Information()
    {
        Debug.Log("Age : "+age);
        Debug.Log("Name : " + name2);
    }
}

public class Dog : Animal
{
    public override void Sound()
    {
        Debug.Log("港港");
    }
    public Dog()
    {
        age = 3;
        name2 = "Dog";
        Information();
        
    }
    
}
public class Cat : Animal
{
    public override void Sound()
    {
        Debug.Log("具克");
    }
    public Cat()
    {
        age = 2;
        name2 = "Cat";
        Information();
        
    }
}
public class Duck : Animal
{
    public override void Sound()
    {
        Debug.Log("残");
    }
    public Duck()
    {
        age = 1;
        name2 = "Duck";
        Information();
        
    }
}