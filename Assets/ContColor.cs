using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContColor : MonoBehaviour
{
    public GameObject[] brushColors;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Red")
        {
            brushColors[0].SetActive(true);
        }
        if (collision.gameObject.tag == "Green")
        {
            brushColors[4].SetActive(true);
        }
        if (collision.gameObject.tag == "Pink")
        {
            brushColors[1].SetActive(true);
        }
        if (collision.gameObject.tag == "Yellow")
        {
            brushColors[3].SetActive(true);
        }
        if (collision.gameObject.tag == "Orange")
        {
            brushColors[5].SetActive(true);
        }
        if (collision.gameObject.tag == "Blue")
        {
            brushColors[2].SetActive(true);
        }
      

    }
}
