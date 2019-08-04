using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{
    public GameObject player;

    private HealthScript hs;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        hs = player.GetComponent<HealthScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + -transform.right * 8f * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.gameObject.CompareTag("Player"))
        {
            hs.TakeHit();
            Destroy(transform.gameObject);
        }
    }
}
