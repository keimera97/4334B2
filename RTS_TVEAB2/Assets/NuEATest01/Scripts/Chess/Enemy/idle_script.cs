using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idle_script : MonoBehaviour
{
    base_behavior bb;


    // Start is called before the first frame update
    void Start()
    {
        bb = gameObject.GetComponent<base_behavior>();
        


        if (bb.idleScript == null)
        {
            bb.idleScript = gameObject.AddComponent<idle>();
            
            bb.idleScript.weight = 1.0f;
            bb.idleScript.enabled = true;

            //bb.fleeScript = gameObject.AddComponent<Flee>();
            //bb.fleeScript.target = target;
            //bb.fleeScript.enabled = true;
        }

    }


    private void OnDestroy()
    {
        DestroyImmediate(bb.seekScript);
    }



}
