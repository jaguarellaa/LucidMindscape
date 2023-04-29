using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EventsManager : MonoBehaviour
{
    public EventsManager Instance{ get; private set; }
    

    private void Awake()
    {
        if (Instance != this && Instance != null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    
    public event Action onTargetObtained;

    public void TargetObtained()
    {
        if (onTargetObtained != null)
        {
            onTargetObtained();
        }
    }
    
    
}

