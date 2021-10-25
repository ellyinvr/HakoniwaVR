using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonItem_X : MonoBehaviour
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
        GameObject objX = Instantiate(ball, new Vector3(rightController.transform.position.x - 0.2f, rightController.transform.position.y + 0.1f, rightController.transform.position.z + 0.2f), Quaternion.Euler(-90f, 0, 0));
        objX.transform.localScale = new Vector3(objX.transform.localScale.x * 0.8f, objX.transform.localScale.y * 0.8f, objX.transform.localScale.z * 0.8f);
    }

}
