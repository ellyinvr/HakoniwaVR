using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonInteractionMenuSettings : MonoBehaviour
{
    public GameObject settings;


    public void OnButtonClicked()
    {
        settings.SetActive(true);
    }

}
