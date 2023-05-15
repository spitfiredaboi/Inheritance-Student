using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungSwung : Weapon
{
    //Swung variables
    public float swingSpeed;
    public float swingDegrees;

    public override void Attack()
    {
        //Rotate to start pos
        transform.localEulerAngles = new Vector3(0, 0, -swingDegrees);
        //activate weapom
        EnableWeapon();

        //swing and deactivate
        StartCoroutine(Swing());
    }
    IEnumerator Swing()
    {
        float degrees = 0;
        while(degrees < swingDegrees)
        {
            transform.Rotate(Vector3.forward, swingSpeed * Time.deltaTime);
            degrees += swingSpeed * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        DisableWeapon();
    }
}
