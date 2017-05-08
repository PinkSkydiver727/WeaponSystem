using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTarget : MixinBase {

    public float damage;
    public override void Action(GameObject target)
    {
        HealthController healthController = target.GetComponent<HealthController>();
        if(healthController)
        {
            healthController.TakeDamage(damage);
        }
    }
}
