using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : Player {

    void Start()
    {
        LoadPrefsandInit();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < upperLimit)
        {
            transform.position += new Vector3(0, padSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > lowerLimit)
        {
            transform.position += new Vector3(0, -padSpeed * Time.deltaTime);
        }
    }
}
