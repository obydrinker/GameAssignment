using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship1 : MonoBehaviour
{
    //variables
    public int spaceshipSpeed;
    [Range(-300, 300)]
    public float spaceshipRotationSpeed1;//higher rotation speed.
    [Range(-200, 200)]
    public float spaceshipRotationSpeed2;//less rotation speed.
    public SpriteRenderer spaceshipBodyColor;
    public Color newcolor;
    public float timer;
    public float timerPrint;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //code for movement of the spaceship and the change of color if rotating. 
        transform.Translate(0, spaceshipSpeed * Time.deltaTime, 0, Space.Self);
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, -spaceshipRotationSpeed1 * Time.deltaTime);
            spaceshipBodyColor.color = new Color(0f, 0f, 1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, spaceshipRotationSpeed2 * Time.deltaTime);
            spaceshipBodyColor.color = new Color(0f, 1f, 0f);
        }
        //code for slowing down the spaceship speed by half if holding S.
        if (Input.GetKeyDown(KeyCode.S))
        {
            spaceshipSpeed = spaceshipSpeed / 2;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            spaceshipSpeed = spaceshipSpeed * 2;

        }
        //code for the timer.
        timer = timer + 1 * Time.deltaTime;
        //code for printing the timer each second so its visible.
        if (timerPrint >= 1)
        {
            print(string.Format(
                "Timer:" + timer));
            timerPrint = 0;
        }
        //Checking when the timer is going to print.
        timerPrint = timerPrint + 1 * Time.deltaTime;



    }
}
