using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    //Slider for walking speeds
    float currentSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move to the left (-x direction)
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }
}
