using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SleepAction : Action
{
    [SerializeField]
    private TextMeshProUGUI infoText;
    [SerializeField]
    private Slider hoursSlider;

    private void Update()
    {
        infoText.SetText("Sleep for "+hoursSlider.value+" hours");
        actionDurationHours = (int)hoursSlider.value;
    }

    public override void PerformAction()
    {
        clock.AddMinutes(actionDurationMinutes);
        clock.AddHours(actionDurationHours);
        float totalSleepAmount = -10 * hoursSlider.value;
        Player.Instance.SetWeariness(totalSleepAmount);
        gameObject.SetActive(false);
    }
}
