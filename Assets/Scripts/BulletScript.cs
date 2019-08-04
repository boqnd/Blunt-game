using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private EnemyHealthScript hs;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + transform.right * 8f * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.transform.gameObject.CompareTag("Enemy"))
        {
            hs = other.gameObject.GetComponent<EnemyHealthScript>();
            hs.TakeHit();
            Destroy(transform.gameObject);
        }
    }
}
