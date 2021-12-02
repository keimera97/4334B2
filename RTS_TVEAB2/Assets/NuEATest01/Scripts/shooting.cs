using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    [SerializeField] float intervalForShoot = 5f;
    public GameObject shootingPoint;
    public GameObject bullet;
    [SerializeField] private bool beginningShooting = false;
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "Enemy")
        {
            transform.LookAt(other.transform);
            ReadyToShoot(other);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Enemy")
        {
            transform.LookAt(null);
            beginningShooting = false;
        }
    }
    private void ReadyToShoot(Collider enemy)
    {
        RaycastHit hit;
        Ray r = new Ray(this.transform.position, enemy.gameObject.transform.position);
        Physics.Raycast(r, out hit, this.GetComponent<SphereCollider>().radius);
        if (hit.transform.tag == enemy.transform.tag)
        {
            transform.LookAt(enemy.transform);
            beginningShooting = true;
        }
        else
        {
            beginningShooting = false;
        }
    }
    IEnumerator WaitingTime()
    {
        Instantiate(bullet, shootingPoint.transform.position, shootingPoint.transform.rotation);
        yield return new WaitForSeconds(intervalForShoot);
    }

}
