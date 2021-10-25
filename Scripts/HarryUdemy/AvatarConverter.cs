using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarConverter : MonoBehaviour
{

    public Transform mainAvatarTransform;
    public Transform avatarHead;
    public Transform avatarBody;

    public Transform avatarHand_Left;
    public Transform avatarHand_Right;

    public Transform oculusHead;

    public Transform oculusHand_Left;
    public Transform oculusHand_Right;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mainAvatarTransform.position = Vector3.Lerp(mainAvatarTransform.position, oculusHead.position, 0.5f);

        avatarHead.rotation = Quaternion.Lerp(avatarHead.rotation, oculusHead.rotation, 0.5f);
    }
}
