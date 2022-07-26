using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerState : MonoBehaviour
{
    public GameObject gameoverUI;
    public TextMeshProUGUI scoreUI;

    public int bestscoree;
    void Update()
    {
        scoreUI.text = $"Score : {bestscoree}";
    }

    public void die()
    {
        Destroy(gameObject);
        gameoverUI.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "dead" || other.tag == "water")
        {
            die();
        }
    }
}
