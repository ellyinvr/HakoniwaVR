using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonItem_obj : MonoBehaviour
{
    [SerializeField]
    GameObject plane;

    [SerializeField]
    GameObject ball;

   void start()
   {
       
   }

    public void OnButtonClicked()
    {
         Instantiate(ball, new Vector3(plane.transform.position.x - 0.05f, plane.transform.position.y + 0.6f, plane.transform.position.z), Quaternion.Euler(0, 25f, 0));
    }

}
