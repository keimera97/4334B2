using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 5f,damage = 5f;   
    void Update()
    {
        transform.Translate(0, 0, Time.deltaTime * speed);
        Destroy(gameObject, 1);      
    }

    private void OnTriggerEnter(Collider other)
    {        
        if(other.tag == "Barrier")
        {
            Destroy(this.gameObject);
        }
        if(other.tag == "Enemy")
        {
            Destroy(this.gameObject);
            other.GetComponent<EnamyHealth>().TakingDamage(damage);
        }
    }
}
