using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadClip : MixinBase {

    public float reloadTimer;
    float reloadTime;

    bool reloading;
    public int reloadAmount;
    CheckClip checkClip;

    void Start()
    {
        checkClip = GetComponent<CheckClip>();
    }

    public override void Action()
    {
        if (!reloading)
        {
            reloading = true;
            reloadTime = 0.0f;
        }
    }

    public void Update()
    {
        if(reloading)
        {
            print("reloading : " + reloadTime);
            reloadTime += Time.deltaTime;
            if(reloadTime >= reloadTimer)
            {
                checkClip.SetClipCout(reloadAmount);
                reloading = false;
                reloadTime = 0.0f;
            }
        }
    }
    
}
