using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowerAction : Action
{
    [SerializeField]
    private int cleanRate = 50;

    public override void PerformAction()
    {
        clock.AddMinutes(actionDurationMinutes);
        clock.AddHours(actionDurationHours);
        Player.Instance.SetCleanness(cleanRate);
        gameObject.SetActive(false);
    }
}
