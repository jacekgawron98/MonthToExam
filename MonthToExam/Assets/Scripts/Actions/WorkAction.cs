using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkAction : Action
{
    [SerializeField]
    private int payment;

    public override void PerformAction()
    {
        int totalPayment = (payment + (int)Player.Instance.Intelligence - (int)Player.Instance.Weariness+1);
        Player.Instance.SetMoney(totalPayment);
        clock.AddMinutes(actionDurationMinutes);
        clock.AddHours(actionDurationHours);
        transform.parent.parent.gameObject.SetActive(false);
    }
}
