using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    GameObject rightController;
     [SerializeField]
    GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {
        if(OVRInput.GetDown(OVRInput.RawButton.A))
        {
            //球を生成（「ヒエラルキーで右クリック→Create→3D Object→Sphere」と同じ作業です）
            // GameObject go = Instantiate(GameObject.CreatePrimitive(PrimitiveType.Sphere));
            Instantiate(ball, rightController.transform.position, Quaternion.identity);

            //生成した球の位置を右手コントローラの位置に変更
            // go.transform.position = rightController.transform.position;
            //生成した球のサイズを半径0.1mに変更
            // ball.transform.localScale *= 0.1f;
        }        
    }
}