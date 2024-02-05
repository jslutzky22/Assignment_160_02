using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon
{
    public Gun() : base()
    {
        base.weaponName = "TommyGun";
        WeaponStrength = 700;
    }

    public Gun(string wName)
    {
        weaponName = wName;
        WeaponStrength += 10;
    }
}
