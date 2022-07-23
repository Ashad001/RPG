using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : Collidable
{
    protected override void OnCollide(Collider2D collide)
    {
        Debug.Log("Chest Unlocked");
    }
}
