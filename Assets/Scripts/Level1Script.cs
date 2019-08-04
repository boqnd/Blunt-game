using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Script : MonoBehaviour
{
    public GameObject police;
    public GameObject police2;
    public GameObject police3;
    
    public int level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (level == 1)
        {
            if (!police.active)
            {
                SceneManager.LoadScene("2Level");
            }
        }else if (level == 2)
        {
            if (!police.active && !police2.active)
            {
                SceneManager.LoadScene("3Level");
            }
        }else if (level == 3)
        {
            if (!police.active && !police2.active && !police3.active)
            {
                SceneManager.LoadScene("4Level");
            }
        }

    }
}
