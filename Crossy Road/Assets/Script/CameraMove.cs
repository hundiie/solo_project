using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float CameraSpeed;
    private void Update()
    {
        Vector3 cameraN = this.transform.position;
        cameraN.z += CameraSpeed;
        transform.position = cameraN;
    }
}
