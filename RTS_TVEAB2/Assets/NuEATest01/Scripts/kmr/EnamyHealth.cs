using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnamyHealth : MonoBehaviour
{
    [SerializeField]private float health = 100f;
    // Start is called before the first frame update
    private void Update()
    {
        if(health <= 0)
        {
            Death();
        }
    }
    private void Death()
    {
        Destroy(this.gameObject);
    }
    public void TakingDamage(float damage)
    {
        if(health > 0)
        {
            health -= damage;
        }
    }
}
