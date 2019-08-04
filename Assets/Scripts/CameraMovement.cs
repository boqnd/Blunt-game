using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private int speed;

    public GameObject player;

    private PlayerController ps;
    // Start is called before the first frame update
    void Start()
    {
        ps = player.GetComponent<PlayerController>();
        speed = ps.speed;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (horizontal > 0)
        {
            transform.Translate(Vector3.right*Time.deltaTime* horizontal * speed);
        }

        if (horizontal<0)
        {
            transform.Translate(Vector3.left*Time.deltaTime* horizontal * speed * -1);        
        }

        transform.position = new Vector3(transform.position.x,player.transform.position.y,-10);
    }
}
