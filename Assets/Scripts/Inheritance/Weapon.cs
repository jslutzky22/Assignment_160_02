using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon 
{
    protected string weaponName;
    protected int weaponStrength;

    protected int WeaponStrength { get => weaponStrength; set => weaponStrength = value; }

    
    protected virtual void UseWeapon(int damage)
    {
        WeaponStrength -= damage; //weaponStrength = weaponStrength - damage
    }
}
