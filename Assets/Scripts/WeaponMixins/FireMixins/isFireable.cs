using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isFireable : MonoBehaviour {

    public bool fireable;

    public List<MixinBase> fireChecks;
    public List<MixinBase> fireActions;


    public void TryFire()
    {
        fireable = true;

        for(int i = 0; i < fireChecks.Count; i++)
        {
            fireChecks[i].Check();
        }

        if(fireable)
        {
            for (int i = 0; i < fireActions.Count; i++)
            {
                fireActions[i].Action();
            }
        }
    }
}
