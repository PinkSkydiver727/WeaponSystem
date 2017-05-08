using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MixinBase {

    public GameObject projectile;
    public Transform firePos;
    public override void Action()
    {
        Instantiate(projectile, firePos.position, firePos.rotation);
    }
}
