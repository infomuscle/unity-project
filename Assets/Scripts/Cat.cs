using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    
    // Profile Variable
    private bool alive;
    
    private string name;
    private string sex;
    private string stage;
    private int age;
    private string breed;
    
    // Status Variable
    private int fun;
    private int clean;
    private int full;
    private int health;

    public void Awake()
    {
        this.alive = true;
        
        this.name = PlayerPrefs.GetString("name");
        this.sex = PlayerPrefs.GetString("sex");
        this.breed = PlayerPrefs.GetString("breed");
        
        this.stage = "Baby";
        this.age = 0;
    }

    void Start()
    {
        this.fun = 50;
        this.clean = 50;
        this.full = 50;
        this.health = 50;

        Debug.Log("Hi, my name is " + name);
    }

    private void Update()
    {
        
    }
}
