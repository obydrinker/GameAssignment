using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship1 : MonoBehaviour {
    //variables
    public int spaceshipSpeed;
    [Range(-1000, 1000)]
    public float spaceshipRotationSpeed;


	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        //code for movement of the spaceship and the change of color if rotating.
        transform.Translate(0, spaceshipSpeed * Time.deltaTime, 0, Space.Self);
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, -spaceshipRotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, spaceshipRotationSpeed * Time.deltaTime);
        }

            
		
	}
}
