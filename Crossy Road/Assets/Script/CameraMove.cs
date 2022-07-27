using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float CameraSpeed;
    public float maxspeed;
    public GameObject PLAYER;
    private void Update()
    {
        Vector3 cameraN = this.transform.position;
        cameraN.z += CameraSpeed * Time.deltaTime;
        
        if (transform.position.z < PLAYER.transform.position.z + maxspeed)
        {
            cameraN.z += CameraSpeed * 4 * Time.deltaTime;
        }
        transform.position = cameraN;
    }
}
