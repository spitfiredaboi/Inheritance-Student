using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon
{
    public GameObject hotdog;
    public GameObject player;
    public float rotationBalance = -90;
    public 

    override void Attack()
    {
        if (canAttack)
        {
            player = GameObject.Find("Player");
            //Instantiate(hotdog, gameObject.transform.position, new Quaternion(player.transform.rotation.x, player.transform.rotation.y, player.transform.position.z + rotationBalance, 0));
            Instantiate(hotdog, gameObject.transform.position, transform.rotation);
            EnableWeapon();
            Invoke("DisableWeapon", attackDuration);
            // Set a timer to reset the weapon's attack ability.
            Invoke("AttackReset", 60f / attackRate);
        }
    }
}
