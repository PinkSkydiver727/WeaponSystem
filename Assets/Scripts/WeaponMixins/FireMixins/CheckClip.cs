using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckClip : MixinBase
{

    public int clipSize;
    [SerializeField]
    int clipCount;

    public isFireable fireChecker;
    public MixinBase reloadAction;

    void Start()
    {
        clipCount = clipSize;
    }

    public override void Check()
    {
        if (clipCount <= 0)
        {
            fireChecker.fireable = false;
            reloadAction.Action();
        }
    }

    public override void Action()
    {
        clipCount--;
        print("ammo remaining : " + clipCount);
    }


    public void SetClipCout(int count)
    {
        clipCount = count;
    }


}
