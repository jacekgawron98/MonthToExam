using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntertainmentAction : Action
{
    [SerializeField]
    private EntertainMentType type;

    public override void PerformAction()
    {
        switch (type)
        {
            case EntertainMentType.PUB:
                {
                    Player.Instance.SetStress(-20);
                    Player.Instance.SetHunger(-80);
                    Player.Instance.SetWeariness(20);
                    clock.AddMinutes(actionDurationMinutes);
                    clock.AddHours(actionDurationHours);
                    transform.parent.parent.gameObject.SetActive(false);
                    break;
                }
            case EntertainMentType.GYM:
                {
                    Player.Instance.SetStress(-10);
                    Player.Instance.SetHealth(20);
                    Player.Instance.SetWeariness(5);
                    clock.AddMinutes(actionDurationMinutes);
                    clock.AddHours(actionDurationHours);
                    transform.parent.parent.gameObject.SetActive(false);
                    break;
                }
            case EntertainMentType.MOVIE:
                {
                    Player.Instance.SetStress(-5);
                    Player.Instance.SetWeariness(-30);
                    clock.AddMinutes(actionDurationMinutes);
                    clock.AddHours(actionDurationHours);
                    transform.parent.parent.gameObject.SetActive(false);
                    break;
                }
        }
    }
}

enum EntertainMentType
{
    MOVIE,
    GYM,
    PUB,
}
