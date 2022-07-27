using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_flower : MonoBehaviour
{
    public GameObject flower;

    private int randomnum;
    private void Start()
    {
        Vector3 flowermake = this.transform.position;
        flowermake.x += -10.0f;
        flowermake.y += 0.5f;
        for (int i = 0; i < 20; i++)
        {
            randomnum = Random.Range(1, 3);
            switch (randomnum)
            {
                case 1:
                    Instantiate(flower, flowermake, transform.rotation);
                    break;
                default: 
                    break;
            }
            flowermake.x += 1.0f;
        }
    }
}
