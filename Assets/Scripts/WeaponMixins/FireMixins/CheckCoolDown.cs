using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCoolDown : MixinBase {

    public isFireable fireChecker;
    public float cooldownTimer;
    float cooldownTime;

    public override void Action()
    {
        cooldownTime = 0.0f;
    }

    public override void Check()
    {
        if(cooldownTime <= cooldownTimer)
        {
            fireChecker.fireable = false;
        }
    }

    void Update()
    {
        if(cooldownTime <= cooldownTimer)
        {
            cooldownTime += Time.deltaTime;
        }
    }

    
}
