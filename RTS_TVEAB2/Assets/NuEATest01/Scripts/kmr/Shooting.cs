using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
 {
    [SerializeField] float intervalForShoot = 100f;
    public GameObject shootingPoint;
    public GameObject checkingPoint;
    public GameObject bullet;

    private float nextForFire = 0f;

    [SerializeField] private bool beginningShooting = false;
    [SerializeField] private LayerMask layerMask;

    private void Update()
    {
        if (beginningShooting && Time.time >= nextForFire)
        {
            nextForFire = Time.time + 5f / intervalForShoot;
            Instantiate(bullet, shootingPoint.transform.position, shootingPoint.transform.rotation);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "Enemy")
        {

            checkingPoint.transform.LookAt(other.transform);

            RaycastHit hit;

            Ray r = new Ray(checkingPoint.transform.position, checkingPoint.transform.forward);
            Physics.Raycast(r, out hit, this.GetComponent<SphereCollider>().radius, layerMask);
            //Debug.DrawLine(checkingPoint.transform.position, Vector3.forward, Color.red, this.GetComponent<SphereCollider>().radius, true);
            if (hit.transform.tag != "Enemy")
            {
                transform.LookAt(null);
                Debug.Log("this is not Enemy\n" + "tag:" + hit.transform.tag.ToString() + " Name:" + hit.transform.name.ToString());
                beginningShooting = false;
            }
            if (hit.transform.tag == "Enemy")
            {
                transform.LookAt(other.transform);
                beginningShooting = true;
            }                      
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Enemy")
        {
            nextForFire = 0f;
            checkingPoint.transform.LookAt(null);
            beginningShooting = false;

        }
    }
   
    /* private void ReadyToShoot(Collider enemy)
     {        
         RaycastHit hit;       
         Ray r = new Ray(checkingPoint.transform.position, Vector3.forward);       
         Physics.Raycast(r, out hit, this.GetComponent<SphereCollider>().radius,layerMask);
         Debug.DrawRay(checkingPoint.transform.position, Vector3.forward, Color.red, this.GetComponent<SphereCollider>().radius, true);

         if (hit.transform.tag == "Enemy")
         {         
             beginningShooting = true;
             this.transform.LookAt(enemy.transform);
         }
          if (hit.transform.tag != "Enemy")
         {
             Debug.Log("this is not Enemy\n"+"tag:"+hit.transform.tag.ToString()+" Name:"+ hit.transform.name.ToString());
             beginningShooting = false;
             this.transform.LookAt(null);
         }       
     }   */

}

