using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonInteractionMenuHTP : MonoBehaviour
{

    // public TextMeshProUGUI simpleUIText; 
    public GameObject htp;
    public GameObject settings;


    public void OnButtonClicked()
    {
        htp.SetActive(false);
        settings.SetActive(true);

    }

}
