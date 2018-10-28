using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {

    public float padSpeed;

    void Awake()
    {
        switch (PlayerPrefs.GetInt("padSpeed"))
        {
            case 0:
                padSpeed = 1f;
                break;
            case 1:
                padSpeed = 2f;
                break;
            case 2:
                padSpeed = 5f;
                break;
        }

        switch (PlayerPrefs.GetInt("padSize"))
        {
            case 0:
                transform.localScale = new Vector3(1f, 0.3f, 1f);
                break;
            case 1:
                transform.localScale = new Vector3(2f, 0.3f, 1f);
                break;
            case 2:
                transform.localScale = new Vector3(3f, 0.3f, 1f);
                break;
        }
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += new Vector3(0, padSpeed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += new Vector3(0, -padSpeed * Time.deltaTime);
        }
    }
}
