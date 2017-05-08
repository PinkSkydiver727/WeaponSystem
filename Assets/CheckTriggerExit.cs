using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTriggerExit : MonoBehaviour
{

    public string OnTriggerMessage;

    void OnTriggerExit(Collider other)
    {
        GameObject target = other.gameObject;
        if (target)
        {
            SendMessage(OnTriggerMessage, target);
        }
    }
}
