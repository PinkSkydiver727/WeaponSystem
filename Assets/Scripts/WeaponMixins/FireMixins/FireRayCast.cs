using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRayCast : MixinBase {

    public Transform firePos;
    public MixinBase tryDamage;
    public override void Action()
    {
        RaycastHit hit;

        if (Physics.Raycast(firePos.position, firePos.forward, out hit))
        {
            tryDamage.Action(hit.transform.gameObject);
        }
    }
}
