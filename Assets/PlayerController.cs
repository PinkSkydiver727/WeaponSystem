using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float rotateSpeed;
    public float speed;
    public WeaponController weaponController;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalAxis * speed);
        transform.Rotate(Vector3.up * rotateSpeed * horizontalAxis);

        if(Input.GetButton("Fire1"))
        {
            weaponController.FireWeapon();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            weaponController.ChangeWeapon();
        }


    }
}
