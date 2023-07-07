using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 20.0f; //Variable to control how fast tank moves
    public float turnSpeed = 15.0f;                        
    public float xInput; // Left & Right
    public float zInput; // Forward & back
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal"); // Grabs the user input from the left & right arrow keys (A & D too)
        zInput = Input.GetAxis("Vertical"); // 
        
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * zInput); // Controls forward/backward movement
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * xInput); // Controls left/right movement 
    }
}
