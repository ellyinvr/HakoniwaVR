using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonInteractionShow : MonoBehaviour
{

    // public TextMeshProUGUI simpleUIText; 
    public GameObject objects;
    public GameObject walkarea;
    public GameObject settingMenu;
    public GameObject hammer;


    public void OnShowButtonClicked()
    {
        objects.SetActive(true);
        walkarea.SetActive(true);
        hammer.SetActive(true);
        settingMenu.SetActive(false);
        //RenderSettings.skybox = sky;
    }

   
}


   