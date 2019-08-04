using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public GameObject playerSpawnPoint;
    public GameObject cameraSpawnPoint;
    public Camera camera;
    public Slider slider;
    public Slider enemySlider;
    public GameObject deathScreen;
    public GameObject police;
    public GameObject police2;
    public Slider enemySlider2;
    public GameObject police3;
    public Slider enemySlider3;
    public PlayerController pc;
    public void TakeHit()
    {
        slider.value -= 1;
        if (slider.value<1)
        {
            Die();
        }
    }

    public void Die()
    {
        Time.timeScale = 0f;
        deathScreen.SetActive(true);
        slider.gameObject.SetActive(false);
    }

    public void Reset()
    {
        Time.timeScale = 1f;
        deathScreen.SetActive(false);
        slider.gameObject.SetActive(true);
        police.SetActive(true);
        if (police2 != null)
        {
            police2.SetActive(true);
            enemySlider2.value = enemySlider2.maxValue;
        }
        if (police3 != null)
        {
            police3.SetActive(true);
            enemySlider3.value = enemySlider3.maxValue;
        }
        slider.value = slider.maxValue;
        enemySlider.value = enemySlider.maxValue;
        Spawn();
    }
    
    public void Spawn()
    {
        transform.position = playerSpawnPoint.transform.position;
        camera.transform.position = cameraSpawnPoint.transform.position;
    }
}
