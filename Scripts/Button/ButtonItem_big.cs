﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonItem_big : MonoBehaviour
{
    [SerializeField]
    GameObject rightController;
    [SerializeField]
   GameObject ball;

   void start()
   {
       
   }

    public void OnButtonClicked()
    {

       GameObject obj = Instantiate(ball, new Vector3(rightController.transform.position.x - 0.2f, rightController.transform.position.y + 0.1f, rightController.transform.position.z + 0.2f), Quaternion.identity);
        obj.transform.localScale = new Vector3(obj.transform.localScale.x * 1.2f, obj.transform.localScale.y * 1.2f, obj.transform.localScale.z * 1.2f);
    }

}
