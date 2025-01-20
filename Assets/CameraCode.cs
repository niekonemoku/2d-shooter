using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCode : MonoBehaviour
{
    public Transform targetPosition;
    public Transform targetRotation;

    void Update()
    {
        transform.position = targetPosition.position - new Vector3(0,0,10);
        //transform.rotation = targetRotation.rotation;
    }
}
