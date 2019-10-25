using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StudyAction : Action
{
    [SerializeField]
    private TextMeshProUGUI infoText;
    [SerializeField]
    private Slider hoursSlider;

    private void Update()
    {
        infoText.SetText("Study for " + hoursSlider.value + " hours");
        actionDurationHours = (int)hoursSlider.value;
    }

    public override void PerformAction()
    {
        float totalAmount = 15 * ((float)actionDurationHours / 24);
        Debug.Log(totalAmount);
        Player.Instance.SetIntelligence(totalAmount);
        clock.AddMinutes(actionDurationMinutes);
        clock.AddHours(actionDurationHours);
        gameObject.SetActive(false);
    }
}
