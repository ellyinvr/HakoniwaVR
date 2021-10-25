using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonInteractionTerrain : MonoBehaviour
{

    // public TextMeshProUGUI simpleUIText; 
    public GameObject t1;
    public GameObject t2;
    public GameObject t3;
    public GameObject t4;


    public void OnT1ButtonClicked()
    {

        t1.SetActive(true);

        t2.SetActive(false);

        t3.SetActive(false);

        t4.SetActive(false);

    }

    public void OnT2ButtonClicked()
    {

        t1.SetActive(false);

        t2.SetActive(true);

        t3.SetActive(false);

        t4.SetActive(false);

    }

    public void OnT3ButtonClicked()
    {

        t1.SetActive(false);

        t2.SetActive(false);

        t3.SetActive(true);

        t4.SetActive(false);

    }

    public void OnT4ButtonClicked()
    {

        t1.SetActive(false);

        t2.SetActive(false);

        t3.SetActive(false);

        t4.SetActive(true);

    }
}


   