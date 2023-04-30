using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPlacement : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Image>().sprite.name == GetComponent<Image>().sprite.name)
        {
            other.GetComponent<RectTransform>().position = GetComponent<RectTransform>().position;
            other.GetComponent<DragDrop>().enabled = false;
            MatchPaintingManager.Instance.matchCount++;
        }
    }
}
