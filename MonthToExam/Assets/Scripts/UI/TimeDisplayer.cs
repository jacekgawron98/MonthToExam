using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

public class TimeDisplayer : MonoBehaviour
{
    [SerializeField]
    ClockManager clock;

    TextMeshProUGUI text;

    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();   
    }

    void Update()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("DAY: " + clock.Day + " ");
        if (clock.Hours < 10)
            stringBuilder.Append("0"+clock.Hours+":");
        else
            stringBuilder.Append(clock.Hours + ":");
        if (clock.Minutes < 10)
            stringBuilder.Append("0" + clock.Minutes);
        else
            stringBuilder.Append(clock.Minutes);

        text.SetText(stringBuilder);
    }
}
