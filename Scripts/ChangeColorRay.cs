using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorRay : MonoBehaviour
{

    //[SerializeField]
    //GameObject obj;

    public void OnButtonClicked()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}