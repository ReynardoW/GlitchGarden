using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Timer player has to survive in seconds")]
    [SerializeField] float levelTimer = 100;
    bool triggeredLevelFinished = false;

    // Update is called once per frame
    void Update()
    {
        if(triggeredLevelFinished) { return; }

        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTimer;
        
        bool timerFinished = (Time.timeSinceLevelLoad >= levelTimer);
        if(timerFinished)
        {
            FindObjectOfType<LevelController>().LevelTimerFinished();
            triggeredLevelFinished = true;
        }
    }
}
