using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkTarget : MonoBehaviour {

    public Material markedMaterial;

    public void SendMarked(HealthController healthController)
    {
        healthController.gameObject.GetComponent<MeshRenderer>().material = markedMaterial;
    }


}
