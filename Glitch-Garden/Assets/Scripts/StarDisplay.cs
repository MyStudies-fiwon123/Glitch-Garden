﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{

    [SerializeField] int stars = 100;
    Text startText;

    // Start is called before the first frame update
    void Start()
    {
        startText = GetComponent<Text>();
        UpdateDisplay();
    }

    // Update is called once per frame
    void UpdateDisplay()
    {
        startText.text = stars.ToString();
    }

    public bool HaveEnoughStars(int amount)
    {
        return stars >= amount;
    }

   public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }

    public void SpendStars(int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            UpdateDisplay();
        }
    }
}
