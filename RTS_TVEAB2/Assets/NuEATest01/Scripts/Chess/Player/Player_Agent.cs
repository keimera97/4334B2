using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

public class Player_Agent : MonoBehaviour
{
    [SerializeField] public Transform movePosTransform;

    private NavMeshAgent navMeshAgent;
    SelectableCharacter selected;
    private Rigidbody rb;
    Vector3 destination;
    [Range(1.0f,100f)]public float moveSpeed;
    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        
    }

// Update is called once per frame
void Update()
    {
     if (selected == true && Input.GetMouseButtonDown(1))
        {
            if (Vector3.Distance(destination, movePosTransform.position) > 1.0f)
            {
                destination = movePosTransform.position;
                navMeshAgent.destination = destination;
            }
        }
    }
        

}
