using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopItemPanel : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI nameText;
    [SerializeField]
    private TextMeshProUGUI priceText;
    [SerializeField]
    private TextMeshProUGUI quantityText;
    [SerializeField]
    private TextMeshProUGUI descriptionText;
    [SerializeField]
    private Image itemIcon;
    [SerializeField]
    private Food item;
    [SerializeField]
    private ShopAction shopAction;

    [SerializeField]
    private EatAction eatAction;

    public int ItemQuantity;
    public Food Item { get { return item; } set { item = value; } }

    void Start()
    {
        nameText.SetText(item.name);
        if(priceText != null)
            priceText.SetText("Price: " + item.Price);
        if (quantityText != null)
            quantityText.SetText("Quantity: " + Player.Instance.Items[item]);
        descriptionText.SetText(item.Description + " Eat duration: "+item.EatDurationInMinutes+"min");
        itemIcon.sprite = item.ItemSprite;
        if(shopAction != null)
            shopAction.Item = item;
        if (eatAction != null)
            eatAction.Item = item;
    }
}
