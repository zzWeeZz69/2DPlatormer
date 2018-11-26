using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraFollow : MonoBehaviour
{
    public Transform Target;
    public float Smoothcamera;
    public Vector3 offset;

    void LateUpdate()
    {
        if (Target != null)
        {
            transform.position = Target.position + offset;

        }
    }

}
