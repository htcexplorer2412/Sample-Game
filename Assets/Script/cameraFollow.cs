using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offSet;

    void Update()
    {
        Vector3 desiredPostion = target.position + offSet;
        Vector3 smoothPositon = Vector3.Lerp(transform.position,desiredPostion,smoothSpeed);
        transform.position = smoothPositon;

        transform.LookAt(target); 
        
    }
}
