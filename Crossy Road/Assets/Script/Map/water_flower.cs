using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_flower : MonoBehaviour
{
    public GameObject flower;

    private int randomnum;
    private void Start()
    {
        Vector3 logmake = this.transform.position;
        logmake.x += -10.0f;
        logmake.y += 0.5f;
        for (int i = 0; i < 20; i++)
        {
            randomnum = Random.Range(1, 4);
            switch (randomnum)
            {
                case 1:
                    Instantiate(flower, logmake, transform.rotation);
                    break;
                default:
                    break;
            }
            logmake.x += 1.0f;
        }
    }
}
