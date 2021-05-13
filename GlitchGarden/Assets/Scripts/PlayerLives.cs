using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    [SerializeField] float baseLives = 3;
    Text playerLivesText;
    float playerLives;

    // Start is called before the first frame update
    void Start()
    {
        playerLives = baseLives - PlayerPrefsController.GetDifficulty();
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
