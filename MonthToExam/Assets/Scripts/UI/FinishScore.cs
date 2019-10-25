using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinishScore : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText;

    void Update()
    {
        int total = (int)(Player.Instance.Intelligence + Player.Instance.Health - Player.Instance.Weariness - Player.Instance.Stress);
        total = Mathf.Clamp(total, 0, 100);
        scoreText.SetText("EXAM RESULTS: " + total+"%");
    }
}
