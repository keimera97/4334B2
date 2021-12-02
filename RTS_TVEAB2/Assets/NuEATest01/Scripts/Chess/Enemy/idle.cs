using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idle : AgentBehavior
{
    public override steering GetSteering()
    {
        steering steer = new steering();
        //steer.linear = target.transform.position = transform.position;
        steer.linear.Normalize();
       // steer.linear = steer.linear *agent.maxAccel;
        return steer;
    }
}
