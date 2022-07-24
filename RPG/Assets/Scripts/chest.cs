using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : Collectable
{
    public Sprite EmptyChest;
    public int Reward = 10;

    protected override void OnCollect()
    {
        if(!Collected)
        {
            Collected = true;
            GetComponent<SpriteRenderer>().sprite = EmptyChest;
            Debug.Log("Reward " + Reward);
        }
    }
}
