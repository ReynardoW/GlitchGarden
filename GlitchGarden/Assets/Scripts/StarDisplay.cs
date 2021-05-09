using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;
    Text starsText;
    void Start()
    {
        starsText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        starsText.text = stars.ToString(); 
    }
    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }
    public bool HaveEnoughStars(int amount)
    {
        return stars >= amount;
    }
    public void SpendStars(int amount)
    {
        if(stars >= amount)
        {
            stars -= amount;
            UpdateDisplay();
        }
    }
}
