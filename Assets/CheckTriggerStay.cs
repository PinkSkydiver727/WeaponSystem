using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTriggerStay : MonoBehaviour
{

    public string OnTriggerMessage;

    void OnTriggerStay(Collider other)
    {
        GameObject target = other.gameObject;
        if (target)
        {
            SendMessage(OnTriggerMessage, target);
        }
    }
}
