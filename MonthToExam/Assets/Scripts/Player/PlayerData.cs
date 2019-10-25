using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    private float stress;
    private float intelligence;

    private float hunger;

    private float weariness;
    private float cleanness;
    private float health;

    private int money;

    public PlayerData(float stress, float intelligence, float hunger, float weariness, float cleanness, float health, int money)
    {
        this.stress = stress;
        this.intelligence = intelligence;
        this.hunger = hunger;
        this.weariness = weariness;
        this.cleanness = cleanness;
        this.health = health;
        this.money = money;

    }
}
