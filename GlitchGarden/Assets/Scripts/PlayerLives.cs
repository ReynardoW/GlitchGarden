using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    [SerializeField] int playerLives = 5;
    Text playerLivesText;

    // Start is called before the first frame update
    void Start()
    {
        playerLivesText = GetComponent<Text>();
        UpdateDisplay();
    }
    private void UpdateDisplay()
    {
        playerLivesText.text = playerLives.ToString();
    }
    public void ReduceLives()
    {
        playerLives -= 1;
        UpdateDisplay();
        if(playerLives <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
            //FindObjectOfType<LevelLoader>().LoadDeathScene();
        }
    }
}
