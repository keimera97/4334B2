using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossPoint : MonoBehaviour
{
   public Vector3 Final_Point;
    GameObject Boss_Target;
    public GameObject contact;
    public float Pointz;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

     


    }
    
    void OnTriggerEnter(Collider Boss)
    {
         Debug.Log("Why not working");
        if (Boss.gameObject.tag == "EnemyBoss")
        {
           
            // transform.position =Transform.position
            Pointz+= (Random.Range(10.0f,25.0f));
            contact.transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 1, Pointz);
            //Time.timeScale = 0;


        }
            //Instantiate(explosionPrefab, position, rotation);

           
    }

    
}
