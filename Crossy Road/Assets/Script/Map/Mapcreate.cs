using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapcreate : MonoBehaviour
{
    public GameObject[] Map = new GameObject[5];
    public float bestscore;

    private float inmap;
    private int random;

    public bool flag;

    private float startmapdata = 5.0f;
    private void Start()
    {
        flag = false;
        for (int i = 0; i < 6; i++)
        {
            random = Random.Range(0, 5);
            Vector3 startmap = new Vector3(0, -0.5f, startmapdata);
            if (Map[random].tag == "water")
            {
                startmap = new Vector3(0, -1, startmapdata);
            }
            randomcreat(random, startmap);
            startmapdata += 1.0f;

        }
    }

    void Update()
    {
        if (flag)
        {
            random = Random.Range(0, 5);
            
            inmap = bestscore + 10.0f;
            Vector3 mapp = new Vector3(0, -0.5f, inmap);
            if (Map[random].tag == "water")
            {
                mapp = new Vector3(0, -1, inmap);
            }

            randomcreat(random,mapp);
            flag = false;
        }


    }

    private void randomcreat(int rnum ,Vector3 mapp)
    {
        Instantiate(Map[rnum], mapp, transform.rotation = Quaternion.Euler(0,0,0));
    }
}
