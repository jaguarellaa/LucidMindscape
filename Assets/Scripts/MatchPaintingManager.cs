using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MatchPaintingManager : MonoBehaviour
{
    public static MatchPaintingManager Instance;

    public int matchCount;
    private void Awake()
    {
        if (Instance != this && Instance != null)
        {
            Destroy(Instance);
        }
        else
        {
            Instance = this;
        }
    }

    private void Update()
    {
        Debug.Log(matchCount);
        CheckWin();
    }

    private void CheckWin()
    {
        if (matchCount == 7)
        {
            Debug.Log("You win!");
        }
    }
}
