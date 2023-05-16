using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : PickUp
{
    public float healValue; //who's joe?????

    public override void Activate()
    {
        player.health += healValue;
        base.Activate();
    }
}
