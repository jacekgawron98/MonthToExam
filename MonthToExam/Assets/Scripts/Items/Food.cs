using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Food")]
public class Food : ScriptableObject
{
    [SerializeField]
    private Sprite itemSprite;
    [SerializeField]
    private string description;
    [SerializeField]
    private int hungerRestoration;
    [SerializeField]
    private int eatDurationInMinutes;
    [SerializeField]
    private int price;

    public Sprite ItemSprite { get { return itemSprite; } }
    public string Description { get { return description; } }
    public int HungerRestoration { get { return hungerRestoration; } }
    public int EatDurationInMinutes { get { return eatDurationInMinutes; } }
    public int Price { get { return price; } }
}
