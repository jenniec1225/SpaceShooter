using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example01 : MonoBehaviour
{
    public bool isDog;
    // Start is called before the first frame update
    void Start()
    {
        Dog dog = new Dog();
        Cat cat = new Cat();
        if(isDog)
        {
            dog.Move();
        }
        else
        {
            cat.Move();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}

public class Dog
{
    public int age;
    public void Move()
    {
        Debug.Log("Dog Move!");
    }
}

public class Cat
{
    public int age;
    public void Move()
    {
        Debug.Log("Cat Move~");
    }
}