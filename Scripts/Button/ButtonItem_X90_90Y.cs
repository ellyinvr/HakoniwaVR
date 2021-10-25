using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonItem_X90_90Y : MonoBehaviour
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
        GameObject objY90 = Instantiate(ball, new Vector3(rightController.transform.position.x - 0.2f, rightController.transform.position.y + 0.1f, rightController.transform.position.z + 0.2f), Quaternion.Euler(-90f, 90f, 0));
        objY90.transform.localScale = new Vector3(objY90.transform.localScale.x * 0.8f, objY90.transform.localScale.y * 0.8f, objY90.transform.localScale.z * 0.8f);

    }

}
