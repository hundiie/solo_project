using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class land : MonoBehaviour
{
    public GameObject[] Object = new GameObject[2];

    private int randomnum;
    private void Start()
    {
        Vector3 wallmake = this.transform.position;
        wallmake.x += -10.0f;
        wallmake.y += 1.0f;
        for (int i = 0; i < 20; i++)
        {
            randomnum = Random.Range(1, 5);
            int rani = Random.Range(0, 2);
            if (rani == 1)
            {
                wallmake.y += 0.5f;
            }
            switch (randomnum)
            {
                case 1:Instantiate(Object[rani], wallmake, transform.rotation);
                    break;
                default:
                    break;
            }
            if (rani == 1)
            {
                wallmake.y -= 0.5f;
            }
            wallmake.x += 1.0f;
        }
    }
}
