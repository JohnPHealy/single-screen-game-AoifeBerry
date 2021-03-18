using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using System;
using UnityEngine.SceneManagement;

public class Chest : MonoBehaviour
{

    public int chest;
    public Image Spirit;
    // Start is called before the first frame update
    void Start()
    {
        chest = 0;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);

            chest += 1;

            if (other.gameObject.tag == "Fire" && chest >= 6)
            {
                SceneManager.LoadScene("YouWin");

            }

        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
