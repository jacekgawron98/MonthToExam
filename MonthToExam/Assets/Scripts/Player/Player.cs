using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public static Player Instance;

    private float stress = 0;
    private float intelligence = 0;

    private float hunger = 0;

    private float weariness = 0;
    private float cleanness = 100;
    private float health = 100;

    private int money = 100;

    private Dictionary<Food, short> items;

    //Public properties
    public float Stress
    {
        get { return stress; }
        set { stress = Mathf.Clamp(value, 0, 100); }
    }

    public float Intelligence
    {
        get { return intelligence; }
        set { intelligence = Mathf.Clamp(value, 0, 100); }
    }

    public float Hunger
    {
        get { return hunger; }
        set { hunger = Mathf.Clamp(value, 0, 100); }
    }

    public float Weariness
    {
        get { return weariness; }
        set { weariness = Mathf.Clamp(value, 0, 100); }
    }

    public float Cleanness
    {
        get { return cleanness; }
        set { cleanness = Mathf.Clamp(value, 0, 100); }
    }

    public float Health
    {
        get { return health; }
        set { health = Mathf.Clamp(value, 0, 100); }
    }

    public int Money
    {
        get { return money; }
        set { money = Mathf.Clamp(value, 0, 9999); }
    }

    public Dictionary<Food, short> Items { get { return items; } }

    public Player()
    {
        items = new Dictionary<Food, short>();
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public Player(float stress, float intelligence, float hunger, float weariness, float cleanness, float health, int money)
    {
        this.stress = stress;
        this.intelligence = intelligence;
        this.hunger = hunger;
        this.weariness = weariness;
        this.cleanness = cleanness;
        this.health = health;
        this.money = money;
        items = new Dictionary<Food, short>();

        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void AddItem(Food item)
    {
        if (items.Count == 0)
        {
            Debug.Log("Dodano nowy przedmiot " + item.name);
            items.Add(item, 1);
        }
        else
        {
            foreach (KeyValuePair<Food, short> o in items)
            {
                if (o.Key.name == item.name)
                {
                    items[o.Key] += 1;
                    Debug.Log("Dodano przedmiot " + item.name + " " + o.Value);
                    return;
                }
            }
            Debug.Log("Dodano nowy przedmiot " + item.name);
            items.Add(item, 1);
        }
    }

    public void RemoveItem(Food item)
    {
        foreach (Food key in items.Keys)
        {
            if (key.name == item.name)
            {
                Debug.Log("Usunieto przedmiot " + item.name);
                items[key] -= 1;
                if (items[key] <= 0)
                {
                    Debug.Log("Całkiem usunięto przedmiot " + item.name);
                    items.Remove(key);
                }
                break;
            }
        }
    }

    public void SetStress(float amount)
    {
        if (amount < 0)
            Stress += amount;
        else
            Stress += amount - 2 * (intelligence / 100) - 2 * (health / 100);
    }

    public void SetIntelligence(float amount)
    {
        Debug.Log(amount - 3 * ((Weariness + Stress) / 200));
        Intelligence += amount - 3*((Weariness + Stress) / 200);
    }

    public void SetHealth(float amount)
    {
            Health += amount - 5*(Weariness + Cleanness + Stress + Hunger) / 400;
    }

    public void SetCleanness(float amount)
    {
        Cleanness += amount;
    }

    public void SetWeariness(float amount)
    {
            Weariness += amount + 2*(1 - (Health/100));
    }

    public void SetHunger(float amount)
    {
        Hunger += amount;
    }

    public void SetMoney(int amount)
    {
        Money += amount;
    }
}
