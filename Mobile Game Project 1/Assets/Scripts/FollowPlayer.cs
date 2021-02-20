using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform targetTransform;
    public int followDistance;
    Vector3 tempVec3 = new Vector3();


    void LateUpdate() //https://gamedev.stackexchange.com/questions/147526/only-make-camera-follow-player-on-x-axis
    {
        tempVec3.x = this.transform.position.x;
        tempVec3.y = targetTransform.position.y + followDistance;
        tempVec3.z = this.transform.position.z;
        this.transform.position = tempVec3;

        gameObject.transform.position = new Vector3
            (
             this.transform.position.x,
             tempVec3.y,
             this.transform.position.z
            );
    }
}
