using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{


    [Range(0.0f, 1000.0f)] public static float EHP;

    //public float ememyhp= 100;
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.red;
        EHP = 1000;
    }
    // Update is called once per frame
    void Update()
    {
        if (EHP <= 0)
        {
            Destroy(gameObject);
        }
    }


    /*
     public void TakeDamage(float Damage)
{
    if (gameObject != null)
    {    
        // Do something  
        Destroy(gameObject);
    }
}
     */
}
