/*************************************************************
 * Created by VTC Stu                               *
 * For the Unity Asset Store                                 *
 * This asset falls under the " License"     *
 * For support email leonleung529@gmail.com                *
 *************************************************************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_CC : MonoBehaviour
{
    public GameObject Tar;
   // SelectableCharacter selected;
    public Pointer pointer;
    void Awake()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }

    void Update()
    {
            if ( Input.GetMouseButtonDown(1))
            {
            NewPoint();
            }
        
    }
   void NewPoint()
    {
          
            Tar.transform.position =  pointer.transform.position;
    }
}
