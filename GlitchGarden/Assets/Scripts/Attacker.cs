using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    //Slider for walking speeds
    [Range(0f, 5f)] [SerializeField] float walkSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move to the left (-x direction)
        transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
    }
}
