using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTriggerBox : MonoBehaviour {

    public BoxCollider boxCollider;
    bool triggered = false;
    public float triggerTimer;
    float triggerTime = 0.0f;

    public void Fire()
    {
        if (!triggered)
        {
            boxCollider.enabled = true;
            triggered = true;
        }
    }

    void Update()
    {
        if (triggered)
        {
            triggerTime += Time.deltaTime;
            if (triggerTime >= triggerTimer)
            {
                boxCollider.enabled = false;
                triggerTime = 0.0f;
                triggered = false;
            }              
        }
    }
}
