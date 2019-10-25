using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionButton : MonoBehaviour
{
    [SerializeField]
    private GameObject panel;

    public void ActivatePanel()
    {
        if (!panel.activeInHierarchy)
        {
            DeactivateOtherPanels();
            panel.SetActive(true);
        }
        else
        {
            panel.SetActive(false);
        }
    }

    private void DeactivateOtherPanels()
    {
        GameObject[] panels = GameObject.FindGameObjectsWithTag("ActionPanel");
        foreach(GameObject panel in panels)
        {
            panel.SetActive(false);
        }
    }
}
