using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthScript : MonoBehaviour
{
    public Slider slider;
    
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
        transform.gameObject.SetActive(false);
    }
}
