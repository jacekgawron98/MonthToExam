using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Action : MonoBehaviour
{
    protected ClockManager clock;
    [SerializeField]
    protected int actionDurationMinutes;
    [SerializeField]
    protected int actionDurationHours;

    protected void Awake()
    {
        clock = FindObjectOfType<ClockManager>();
    }

    public abstract void PerformAction();
}
