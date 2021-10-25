using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonItem_90Y: MonoBehaviour
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
        GameObject obj90Y = Instantiate(ball, new Vector3(rightController.transform.position.x - 0.2f, rightController.transform.position.y + 0.1f, rightController.transform.position.z + 0.2f), Quaternion.Euler(0, 90f, 0));
        obj90Y.transform.localScale = new Vector3(obj90Y.transform.localScale.x * 0.8f, obj90Y.transform.localScale.y * 0.8f, obj90Y.transform.localScale.z * 0.8f);

    }

}
