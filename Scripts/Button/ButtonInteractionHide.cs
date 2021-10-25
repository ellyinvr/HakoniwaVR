using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonInteractionHide : MonoBehaviour
{

    public GameObject objects;
    public GameObject walkarea;
    public GameObject settingMenu;
    public GameObject hammer;

    public void OnHideButtonClicked()
    {
        objects.SetActive(false);
        walkarea.SetActive(false);
        hammer.SetActive(false);
        settingMenu.SetActive(true);

    }

   
}


   