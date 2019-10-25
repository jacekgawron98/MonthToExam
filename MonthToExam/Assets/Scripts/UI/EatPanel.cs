using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatPanel : MonoBehaviour
{
    [SerializeField]
    private GameObject itemPanel;

    void Start()
    {
        foreach(KeyValuePair<Food,short> item in Player.Instance.Items)
        {
            GameObject newPanel = Instantiate(itemPanel);
            newPanel.GetComponent<ShopItemPanel>().Item = item.Key;
            newPanel.GetComponent<ShopItemPanel>().ItemQuantity = item.Value;
        }
    }

    public void UpdateItems()
    {
        Debug.Log("Tu powinien być update");
        ResetItems();
        foreach (KeyValuePair<Food, short> item in Player.Instance.Items)
        {
            GameObject newPanel = itemPanel;
            newPanel.GetComponent<ShopItemPanel>().Item = item.Key;
            newPanel.GetComponent<ShopItemPanel>().ItemQuantity = item.Value;
            Instantiate(itemPanel, transform);
        }
    }

    private void ResetItems()
    {
        for(int i = 1; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
    }
}
