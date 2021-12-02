using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePosDirect : MonoBehaviour
{
    Vector3 movepos;
    GameObject emenych;
    void Awake()
    {
        movepos = transform.position;
    }
    
    public void SetMovePosition(Vector3 movepos)
    {
        this.movepos = movepos;

    }
    void update()
    {
        Vector3 moveDir = (movepos - transform.position).normalized;
        if (Vector3.Distance(movepos, transform.position) < 1f) moveDir = Vector3.zero;
        //GameObject.GetComponent<>().Setlocity(moveDir);
    }





}
