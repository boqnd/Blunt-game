using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootingScript : MonoBehaviour
{
    public float fireRate = 0.8f;

    public GameObject bullet;

    public GameObject spawnPoint;

    private float timePassed = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timePassed > fireRate && Input.GetKey(KeyCode.S))
        {
            var currBullet = Instantiate(bullet, spawnPoint.transform.position, spawnPoint.transform.rotation);
            Destroy(currBullet, 5f);
            timePassed = 0;
        }
        else
        {
            timePassed += Time.deltaTime;
        }

    }
}
