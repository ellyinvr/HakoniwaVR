using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_UP : MonoBehaviour
{
    [SerializeField]
    GameObject obj;
    public GameObject hammer;
   
    int PushCount;

    public void OnButtonClicked()
    {
        PushCount++;

        obj.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y + 0.08f, obj.transform.position.z);
        hammer.transform.position = new Vector3(hammer.transform.position.x, hammer.transform.position.y + 0.08f, hammer.transform.position.z);

    }

}
