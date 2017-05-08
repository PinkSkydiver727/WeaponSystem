using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateTarget : MonoBehaviour {

    public Vector3 direction;
    public float speed;
    public Transform target;
	
	// Update is called once per frame
	void Update ()
    {
        target.Translate(direction * speed);	
	}
}
