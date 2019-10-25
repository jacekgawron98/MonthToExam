using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockManager : MonoBehaviour
{
    [SerializeField]
    private GameObject examDayPanel;

    private int day = 1;
    private int hours = 8;
    private int minutes = 0;

    public int Day { get { return day; } }
    public int Hours { get { return hours; } }
    public int Minutes { get { return minutes; } }

    public void AddMinutes(int minutes)
    {
        this.minutes += minutes;
        if(this.minutes >= 60)
        {
            int hours_to_add = this.minutes/60;
            AddHours(hours_to_add);
            this.minutes -= hours_to_add * 60;
        }
    }

    public void AddHours(int hours)
    {
        PerformHourlyStatChange(hours);
        this.hours += hours;
        if(this.hours >= 24)
        {
            int days_to_add = this.hours / 24;
            AddDays(days_to_add);
            this.hours -= days_to_add * 24;
        }
    }

    public void AddDays(int days)
    {
        day += days;
        if (day == 31)
            PerformExamDay();
        else
            PerformNextDay();
    }
    
    private void PerformHourlyStatChange(int hours)
    {
        Player.Instance.SetHunger(3 * hours);
        Player.Instance.SetCleanness(-5 * hours);
        Player.Instance.SetWeariness(5 * hours);
    }

    private void PerformDailyStatChange()
    {
        Player.Instance.SetStress(day);
        Player.Instance.SetHealth(-day);
        Player.Instance.SetIntelligence(-3);
    }

    public void PerformNextDay()
    {
        PerformDailyStatChange();
        ClassesAction.HasAttended = false;
    }

    public void PerformExamDay()
    {
        examDayPanel.SetActive(true);
    }
}
