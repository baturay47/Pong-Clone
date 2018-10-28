using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : Player {

    void Start()
    {
        LoadPrefsandInit();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.y < upperLimit)
        {
            this.transform.position += new Vector3(0, padSpeed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) && transform.position.y > lowerLimit)
        {
            this.transform.position -= new Vector3(0, padSpeed * Time.deltaTime);
        }
    }
}
