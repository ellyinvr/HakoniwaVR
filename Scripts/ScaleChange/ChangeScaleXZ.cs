using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScaleXZ : MonoBehaviour
{
    public GameObject cube;

    const float interval = 0.5f; // 指定秒
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

    private void OnTriggerEnter(Collider other)
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
                    cube.transform.localScale = new Vector3(cube.transform.localScale.x * 0.8f, cube.transform.localScale.y, cube.transform.localScale.z * 0.8f);
                }
                if (HitCount == 2)
                {
                    VibrationManager.instance.VibrateController(0.1f, 0.1f, 0.1f, OVRInput.Controller.RTouch);
                    cube.transform.localScale = new Vector3(cube.transform.localScale.x * 0.8f, cube.transform.localScale.y, cube.transform.localScale.z * 0.8f);
                }
                if (HitCount == 3)
                {
                    VibrationManager.instance.VibrateController(0.1f, 0.1f, 0.1f, OVRInput.Controller.RTouch);
                    cube.transform.localScale = new Vector3(cube.transform.localScale.x * 0.7f, cube.transform.localScale.y, cube.transform.localScale.z * 0.7f);
                }
                if (HitCount == 4)
                {
                    VibrationManager.instance.VibrateController(0.1f, 0.1f, 0.1f, OVRInput.Controller.RTouch);
                    cube.transform.localScale = new Vector3(cube.transform.localScale.x * 0.6f, cube.transform.localScale.y, cube.transform.localScale.z * 0.6f);
                }
                if (HitCount == 5)
                {
                    VibrationManager.instance.VibrateController(0.1f, 0.1f, 0.1f, OVRInput.Controller.RTouch);
                    cube.transform.localScale = new Vector3(cube.transform.localScale.x * 0.6f, cube.transform.localScale.y, cube.transform.localScale.z * 0.6f);
                }

            }
        }
        
    }

}