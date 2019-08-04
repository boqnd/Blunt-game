using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootingL3Script : MonoBehaviour
{
    
    public GameObject bullet;

    public GameObject spawnPoint;

    private bool canShoot;

    // Start is called before the first frame update
    void Start()
    {
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canShoot && Input.GetKey(KeyCode.S))
        {
            var currBullet = Instantiate(bullet, spawnPoint.transform.position, spawnPoint.transform.rotation);
            Destroy(currBullet, 1.2f);
            canShoot = false;
        }
    }

    public void EnableShooting()
    {
        canShoot = true;
    }
}
