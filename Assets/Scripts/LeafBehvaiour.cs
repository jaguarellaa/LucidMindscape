using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeafBehvaiour : MonoBehaviour
{
    private bool isPainted = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isPainted == false)
        {
            if (other.CompareTag("Red"))
            {
                GetComponent<Image>().color = FloverBehaviour.Instance.m_Colors[0];
                Destroy(other.gameObject);
                isPainted = true;
                FloverBehaviour.Instance.changedColorNum++;
            }
            if (other.CompareTag("Blue"))
            {
                GetComponent<Image>().color = FloverBehaviour.Instance.m_Colors[1];
                Destroy(other.gameObject);
                isPainted = true;
                FloverBehaviour.Instance.changedColorNum++;
            }
            if (other.CompareTag("Purple"))
            {
                GetComponent<Image>().color = FloverBehaviour.Instance.m_Colors[2];
                Destroy(other.gameObject);
                isPainted = true;
                FloverBehaviour.Instance.changedColorNum++;
            }
        }
        
        
    }
}
