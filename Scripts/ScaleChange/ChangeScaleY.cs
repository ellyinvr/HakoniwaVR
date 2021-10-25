using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScaleY : MonoBehaviour
{
    public GameObject cube;

    const float interval = 0.4f; // 指定秒
    float timer;
    bool timeron = false;

    int HitCount;

    void Update()
    {
        if (timeron)
        {
          
            timer += Time.deltaTime;

            if (timer >= interval)
            {
                timer = 0;
                timeron = false;
                
            }
        }   
    }


    public void OnTriggerEnter(Collider other)
    {
        if (timeron == false)
        {
            if (other.gameObject.name == "HamTop")
       　　 {
             HitCount++;
             
            timeron = true;
                if (HitCount == 1)
                {
                    VibrationManager.instance.VibrateController(0.1f, 0.1f, 0.1f, OVRInput.Controller.RTouch);
                    cube.transform.localScale = new Vector3(cube.transform.localScale.x, cube.transform.localScale.y * 0.8f, cube.transform.localScale.z);
                }
                if (HitCount == 2)
                {
                    VibrationManager.instance.VibrateController(0.1f, 0.1f, 0.1f, OVRInput.Controller.RTouch);
                    cube.transform.localScale = new Vector3(cube.transform.localScale.x, cube.transform.localScale.y * 0.7f, cube.transform.localScale.z);
                }
                if (HitCount == 3)
                {
                    VibrationManager.instance.VibrateController(0.1f, 0.1f, 0.1f, OVRInput.Controller.RTouch);
                    cube.transform.localScale = new Vector3(cube.transform.localScale.x, cube.transform.localScale.y * 0.6f, cube.transform.localScale.z);
                }
                if (HitCount == 4)
                {
                    VibrationManager.instance.VibrateController(0.1f, 0.1f, 0.1f, OVRInput.Controller.RTouch);
                    cube.transform.localScale = new Vector3(cube.transform.localScale.x, cube.transform.localScale.y * 0.5f, cube.transform.localScale.z);
                }
                if (HitCount == 5)
                {
                    VibrationManager.instance.VibrateController(0.1f, 0.1f, 0.1f, OVRInput.Controller.RTouch);
                    cube.transform.localScale = new Vector3(cube.transform.localScale.x, cube.transform.localScale.y * 0.4f, cube.transform.localScale.z);
                }
            }
    　　　}

    }

}