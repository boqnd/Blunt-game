using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootingScript : MonoBehaviour
{
    public float fireRate = 2f;

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
        if (timePassed > fireRate)
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
