using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : PickUp
{
    public float speedBuff;

    public override void Activate()
    {
        player.moveSpeed += speedBuff;
        player.sr.color = Color.blue;
        base.Activate();
    }

    public override IEnumerator Revert()
    {
        yield return new WaitForSeconds(effectDuration);
        player.moveSpeed -= speedBuff;
        player.sr.color = Color.white;
    }
}
