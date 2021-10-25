using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    GameObject centerEye;

    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            centerEye.transform.position = new Vector3(-0.3f, -0.2f, 0.4f);

        }
    }
}