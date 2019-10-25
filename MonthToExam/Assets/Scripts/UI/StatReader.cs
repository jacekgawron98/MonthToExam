using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatReader : MonoBehaviour
{
    [SerializeField]
    private Image mask;
    [SerializeField]
    private StatType statType;

    private float originalSize;

    private void Start()
    {
        originalSize = mask.rectTransform.rect.width;
    }

    void Update()
    {
        switch (statType)
        {
            case StatType.HUNGER:
                {
                    SetMaskSize(Player.Instance.Hunger);
                    break;
                }
            case StatType.WEARINESS:
                {
                    SetMaskSize(Player.Instance.Weariness);
                    break;
                }
            case StatType.HEALTH:
                {
                    SetMaskSize(Player.Instance.Health);
                    break;
                }
            case StatType.CLEANNESS:
                {
                    SetMaskSize(Player.Instance.Cleanness);
                    break;
                }
            case StatType.INTELIGENCE:
                {
                    SetMaskSize(Player.Instance.Intelligence);
                    break;
                }
            case StatType.STRESS:
                {
                    SetMaskSize(Player.Instance.Stress);
                    break;
                }
        }
    }

    private void SetMaskSize(float amount)
    {
        mask.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal,originalSize * (amount/100));
    }
}

enum StatType
{
    HUNGER,
    WEARINESS,
    CLEANNESS,
    HEALTH,
    INTELIGENCE,
    STRESS,
    MONEY
}