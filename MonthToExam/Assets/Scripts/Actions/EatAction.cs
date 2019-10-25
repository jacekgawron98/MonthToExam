using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatAction : Action
{
    [SerializeField]
    private Food item;

    public Food Item { get { return Item; } set { item = value; } }

    public override void PerformAction()
    {
        Player.Instance.SetHunger(-item.HungerRestoration);
        clock.AddMinutes(item.EatDurationInMinutes);
        Player.Instance.RemoveItem(item);
        transform.parent.parent.gameObject.SetActive(false);
    }
}
