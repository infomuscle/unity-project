using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    // Profile Variable
    private string name;
    private string sex;
    private string stage;
    private int age;
    private string type;
    
    // Status Variable
    private int fun;
    private int clean;
    private int full;
    private int health;
    
    void Start()
    {
        this.fun = 50;
        this.clean = 50;
        this.full = 50;
        this.health = 50;
    }

    void Update()
    {
        
    }
}
