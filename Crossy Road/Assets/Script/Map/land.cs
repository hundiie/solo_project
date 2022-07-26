using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class land : MonoBehaviour
{
    public GameObject[] Object = new GameObject[2];

    private int randomnum;
    private void Start()
    {
        Vector3 logmake = this.transform.position;
        logmake.x += -10.0f;
        logmake.y += 1.0f;
        for (int i = 0; i < 20; i++)
        {
            randomnum = Random.Range(1, 5);
            int rani = Random.Range(0, 2);
            if (rani == 1)
            {
                logmake.y += 0.5f;
            }
            switch (randomnum)
            {
                case 1:Instantiate(Object[rani], logmake, transform.rotation);
                    break;
                default:
                    break;
            }
            if (rani == 1)
            {
                logmake.y -= 0.5f;
            }
            logmake.x += 1.0f;
        }
    }
}
