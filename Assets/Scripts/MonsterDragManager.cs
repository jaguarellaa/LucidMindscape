using System;
using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;
using UnityEngine.SceneManagement;

public class MonsterDragManager : MonoBehaviour
{
    public static MonsterDragManager Instance { get; private set; }
    
    public int monsterCount;
    private int monsterTempCount;

    public GameObject Panel;
    
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }


    private void Start()
    {
        
        foreach (Transform child in transform)
        {
            monsterCount++;
            monsterTempCount = monsterCount;
        }
    }


    private void Update()
    {
        DecreasePanelValue();
    }

    private void DecreasePanelValue()
    {
        if (monsterTempCount == monsterCount + 1)
        {
            var color = Panel.GetComponent<Image>().color;
            Panel.GetComponent<Image>().color = new Color(color.r, color.b, color.g, color.a - 0.25f);
            monsterTempCount = monsterCount;
        }

        if (monsterCount == 0)
        {
            StartCoroutine(ChangeLevel());
        }
    }

    private IEnumerator ChangeLevel()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("ArtGalleryDay1");
    }
}
