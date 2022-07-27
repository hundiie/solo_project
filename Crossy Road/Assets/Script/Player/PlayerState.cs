using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerState : MonoBehaviour
{
    public GameObject gameoverUI;
    public TextMeshProUGUI scoreUI;
    public int bestscoree;

    private Camera mainCarema;
    private void Start()
    {
        mainCarema = Camera.main;
    }
    void Update()
    {
        scoreUI.text = $"Score : {bestscoree}";

        Vector3 pos = mainCarema.WorldToViewportPoint(transform.position);
        Debug.Log($"pos : {pos}");
        if (pos.x < 0f || pos.x > 1f|| pos.y < 0f || pos.y > 1f) die();
    }
    public void die()
    {
        Time.timeScale = 0;
        gameObject.SetActive(false);
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
