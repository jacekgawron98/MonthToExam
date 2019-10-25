using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyReader : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;

    void Update()
    {
        text.SetText("Money:" + Player.Instance.Money);        
    }
}
