using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using System;
using UnityEngine.SceneManagement;

public class FalloffWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Fall")
            {

            SceneManager.LoadScene("MainLevel");
        }

        }
    
}
