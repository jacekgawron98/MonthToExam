using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClassesAction : Action
{
    [SerializeField]
    private TextMeshProUGUI classesInfo;
    private bool areClassesAvaible;
    public static bool HasAttended;

    private void Update()
    {
        if (clock.Hours >= 8 && clock.Hours <= 15 && !HasAttended)
        {
            areClassesAvaible = true;
        }

        if (areClassesAvaible)
            classesInfo.SetText("You have " + actionDurationHours + " hours of classes today");
        else
            classesInfo.SetText("You have no classes for now");
    }

    public override void PerformAction()
    {
        if(clock.Hours >= 8 && clock.Hours <= 15 && areClassesAvaible)
        {
            Player.Instance.SetIntelligence(actionDurationHours);
            clock.AddMinutes(actionDurationMinutes);
            clock.AddHours(actionDurationHours);
            HasAttended = true;
            areClassesAvaible = false;
            gameObject.SetActive(false);
        }
    }
}
