using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using System;
using UnityEngine.SceneManagement;
public class Pickup : MonoBehaviour
{

    public GameObject Spirit1;
    public GameObject Spirit2;
    public GameObject Spirit3;
    public int chest;
    public Image Spirit;
    public GameObject FireText;
    public GameObject YouWin;


    void start ()
    {
        chest = 0;
    }
        
        private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Chest")
        {
           Spirit1.gameObject.SetActive(true);
           // Debug.Log("ghost1");       
        }

        if (other.gameObject.tag == "Chest1")
        {
            Spirit2.gameObject.SetActive(true);
            // Debug.Log("ghost2");       
        }

        if (other.gameObject.tag == "Chest2")
        {
            Spirit3.gameObject.SetActive(true);
            // Debug.Log("ghost3");       
        }

        if (other.gameObject.tag == "Chest")
        {
            Destroy(other.gameObject);
            chest += 1;
        }
        if (other.gameObject.tag == "Chest1")
        {
            Destroy(other.gameObject);
            chest += 1;
        }
        if (other.gameObject.tag == "Chest2")
        {
            Destroy(other.gameObject);
            chest += 1;
        }

        if (other.gameObject.tag == "Fire" && chest >= 6)
         {
            YouWin.gameObject.SetActive(true);
            // SceneManager.LoadScene("YouWin");

        }
        if (other.gameObject.tag == "Fire" && chest <= 6)
        {
            FireText.gameObject.SetActive(true);
        }

        }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Fire" && chest <= 6)
        {
            FireText.gameObject.SetActive(false);
        }
    }
    }




