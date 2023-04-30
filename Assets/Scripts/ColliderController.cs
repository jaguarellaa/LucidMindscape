using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{

    public GameObject[] color;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Red")
        {
            color[0].SetActive(true);
        }
        if (collision.gameObject.tag == "Blue")
        {
            color[1].SetActive(true);
        }
        if (collision.gameObject.tag == "Purple")
        {
            color[2].SetActive(true);
        }
        if (collision.gameObject.tag == "Pink")
        {
            color[3].SetActive(true);
        }
        if (collision.gameObject.tag == "Yellow")
        {
            color[4].SetActive(true);
        }
        if (collision.gameObject.tag == "Green")
        {
            color[5].SetActive(true);
        }
        if (collision.gameObject.tag == "Orange")
        {
            color[6].SetActive(true);
        }
    }
}
