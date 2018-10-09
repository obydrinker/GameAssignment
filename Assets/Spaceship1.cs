using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship1 : MonoBehaviour
{
    //variables
    public int spaceshipSpeed;
    [Range(-300, 300)]
    int spaceshipRotationSpeed;
    public SpriteRenderer spaceshipBodyColor;
    public Color newcolor;
    public float timer;
    public float timerPrint;


    // Use this for initialization
    void Start()
    {
        //randomize ship speed
        spaceshipSpeed = Random.Range(5, 21);
        //randomize ship rotation speed
        spaceshipRotationSpeed = Random.Range(200, 301);
        //randomize the spawnpoint of the ship.
        transform.position = new Vector3(Random.Range(-10f, 11f), Random.Range(-5, 6f));

    }

    // Update is called once per frame
    void Update()
    {
        //code for movement of the spaceship and the change of color if rotating. 
        transform.Translate(0, spaceshipSpeed * Time.deltaTime, 0, Space.Self);
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, -spaceshipRotationSpeed * Time.deltaTime);
            spaceshipBodyColor.color = new Color(0f, 0f, 1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, (spaceshipRotationSpeed-100) * Time.deltaTime);
            spaceshipBodyColor.color = new Color(0f, 1f, 0f);
        }
        //code for slowing down the spaceship speed by half if holding S and returning to normal speed if not holding S.
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

        //code for random color if pressing space.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceshipBodyColor.color = new Color(Random.Range(0f, 2f), Random.Range(0f, 2f), Random.Range(0f, 2f));
        }
        //code for screenwrap.'
        if (transform.position.x <= -10.4)
        {
            transform.position = new Vector3(10.3f, transform.position.y);
        }
        if (transform.position.x >= 10.4)
        {
            transform.position = new Vector3(-10.3f, transform.position.y);

        }
        if (transform.position.y <= -6.5)
        {
            transform.position = new Vector3(transform.position.x, 6.4f);
        }
        if (transform.position.y >= 6.5)
        {
            transform.position = new Vector3(transform.position.x, -6.4f);
        }



    }
}
