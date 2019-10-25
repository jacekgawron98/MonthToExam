using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopAction : Action
{
    private Food item;

    public Food Item { get { return Item; } set { item = value; } }

    public override void PerformAction()
    {
        if(Player.Instance.Money >= item.Price)
        {
            Player.Instance.SetMoney(-item.Price);
            Player.Instance.AddItem(item);
            clock.AddMinutes(actionDurationMinutes);
            clock.AddHours(actionDurationHours);
            transform.parent.parent.gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("NOT ENOUGH MONEY");
        }
    }
}
