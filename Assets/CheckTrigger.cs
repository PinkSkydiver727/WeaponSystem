using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTrigger : MonoBehaviour {

    public string OnTriggerMessage;
    
    void OnTriggerEnter(Collider other)
    {
        GameObject target = other.gameObject;
        if (target)
        {
            SendMessage(OnTriggerMessage, target);
        }
    }
}
