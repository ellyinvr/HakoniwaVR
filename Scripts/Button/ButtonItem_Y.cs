using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonItem_Y : MonoBehaviour
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
        GameObject objY = Instantiate(ball, new Vector3(rightController.transform.position.x - 0.2f, rightController.transform.position.y + 0.1f, rightController.transform.position.z + 0.2f), Quaternion.Euler(0, 180f, 0));
        objY.transform.localScale = new Vector3(objY.transform.localScale.x * 0.8f, objY.transform.localScale.y * 0.8f, objY.transform.localScale.z * 0.8f);

    }

}
