using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class FloverBehaviour : MonoBehaviour
{
    public static FloverBehaviour Instance { get; private set; }
    
    [Header("ColorValues")] [SerializeField]
    public List<Color> m_Colors = new List<Color>();

    [Header("ColorValues")] 
    [SerializeField] private GameObject redHeart;
    [SerializeField] private GameObject blueHeart;
    [SerializeField] private GameObject purpleHeart;
    
    [Header("FloverLocations")]
    [SerializeField] private GameObject tree1;
    private List<Transform> allLocationsTree1 = new List<Transform>();
    [SerializeField] private GameObject tree2;
    private List<Transform> allLocationsTree2 = new List<Transform>();
    [SerializeField] private GameObject tree3;
    private List<Transform> allLocationsTree3 = new List<Transform>();

    private GameObject redHeartObj;
    private GameObject blueHeartObj;
    private GameObject purpleHeartObj;

    public int changedColorNum;

    private int tree1Num = 0;
    private Transform[] bigFlowerChildren;

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

    private void Start()
    {
        foreach (Transform child in tree1.transform)
        {
            allLocationsTree1.Add(child);
        }
        foreach (Transform child in tree2.transform)
        {
            allLocationsTree2.Add(child);
        }
        foreach (Transform child in tree3.transform)
        {
            allLocationsTree3.Add(child);
        }
    }

    public void RedButtonClicked()
    {
        if (redHeartObj == null)
        {
            redHeartObj = Instantiate(redHeart, transform, false);
        }
    }
    public void BlueButtonClicked()
    {
        if (blueHeartObj == null)
        {
            blueHeartObj = Instantiate(blueHeart, transform, false);
        }
    }
    public void PurpleButtonClicked()
    {
        if (purpleHeartObj == null)
        {
            purpleHeartObj = Instantiate(purpleHeart, transform, false);
        }
    }

    private void Update()
    {
        if (redHeartObj != null)
        {
            redHeartObj.transform.position = Input.mousePosition;
        }
        if (blueHeartObj != null)
        {
            blueHeartObj.transform.position = Input.mousePosition;
        }
        if (purpleHeartObj != null)
        {
            purpleHeartObj.transform.position = Input.mousePosition;
        }
        CheckLevelWin();
    }

    private void CheckLevelWin()
    {
        if (changedColorNum == 5)
        {
            bigFlowerChildren = GetComponentsInChildren<Transform>();
            Debug.Log("You Win!!");
            CreateFlovers();
        }
    }

    private void CreateFlovers()
    {
        if (tree1Num <= 10)
        {
            for (int k = 0; k < allLocationsTree3.Count; k++)
            {
                allLocationsTree3[k].gameObject.SetActive(true);
                MatchColors(allLocationsTree3[k]);
            }
            for (int j = 0; j < allLocationsTree2.Count; j++)
            {
                allLocationsTree2[j].gameObject.SetActive(true);
                MatchColors(allLocationsTree2[j]);
            }
            for (int i = 0; i < allLocationsTree1.Count; i++)
            {
                allLocationsTree1[i].gameObject.SetActive(true);
                MatchColors(allLocationsTree1[i]);
                tree1Num++;
            }
        }
        
    }

    private void MatchColors(Transform smallFlower)
    {
        var smallFlowerChildren = smallFlower.GetComponentsInChildren<Transform>();
        

        for (int i = 0; i < smallFlowerChildren.Length; i++)
        {
            if (smallFlowerChildren[i].TryGetComponent<Image>(out Image image))
            {
                smallFlowerChildren[i].GetComponent<Image>().color = bigFlowerChildren[i].GetComponent<Image>().color;
            }
           
            
        }
    }
}
