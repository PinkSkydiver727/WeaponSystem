using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    isFireable equippedWeapon;
    public List<isFireable> weapons;
    public int equippedIndex;
    void Start()
    {
        if(weapons.Count != 0)
        {
            equippedWeapon = weapons[equippedIndex];
            equippedWeapon.transform.root.gameObject.SetActive(true);
        }
    }

    public void ChangeWeapon()
    {
        equippedIndex++;
        if(equippedIndex >= weapons.Count)
        {
            equippedIndex = 0;
        }
        equippedWeapon.gameObject.SetActive(false);
        equippedWeapon = weapons[equippedIndex];
        equippedWeapon.gameObject.SetActive(true);
    }

    public void FireWeapon()
    {
        equippedWeapon.TryFire();
    }

}
