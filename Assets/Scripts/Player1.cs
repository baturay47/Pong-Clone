using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {

    public float padSpeed;

	// Use this for initialization
	void Start () {
        padSpeed = 1f;
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
