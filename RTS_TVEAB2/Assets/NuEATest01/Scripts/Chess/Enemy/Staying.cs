using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staying : MonoBehaviour
{
    public float angular; //rotation 0->360
    public Vector3 linear; //instantaneous velocity
    public Staying()
    {
        angular = 0.0f;
        linear = new Vector3();
    }
}
