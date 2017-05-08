using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTarget : MonoBehaviour {

	public void SendDamage()
    {
        Destroy(gameObject);
    }
}
