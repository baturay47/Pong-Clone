﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private Rigidbody rigidBody;
    public float speed;

    public Vector3 velocity;

    // Use this for initialization

    void Awake()
    {
        switch (PlayerPrefs.GetInt("ballSpeed"))
        {
            case 0:
                speed = 2f;
                break;
            case 1:
                speed = 4f;
                break;
            case 2:
                speed = 6f;
                break;
        }

        switch (PlayerPrefs.GetInt("ballSize"))
        {
            case 0:
                transform.localScale *= 0.2f;
                break;
            case 1:
                transform.localScale *= 0.5f;
                break;
            case 2:
                transform.localScale *= 1f;
                break;
        }
    }

	void Start () {
        rigidBody = GetComponent<Rigidbody>();
        velocity = new Vector3(speed, speed);

        rigidBody.velocity = velocity;
	}

    void Update()
    {
        if (transform.position.x < -8.5f)
        {
            ScoreController.scoreController.GivePointtoPlayer(2);
            ResetBall();
        }
        if (transform.position.x > 8.5f)
        {
            ScoreController.scoreController.GivePointtoPlayer(1);
            ResetBall();
        }
    }

    void OnCollisionEnter(Collision other)
    {
        velocity = CalculateDirection(other.transform.up);
        rigidBody.velocity = velocity;
    }

    private Vector3 CalculateDirection(Vector3 upVectorOfOther)
    {
        return -(2 * Vector3.Dot(velocity, upVectorOfOther) * upVectorOfOther - velocity);
    }

    void ResetBall()
    {
        transform.position = Vector3.zero;

        velocity = new Vector3(speed, speed);
        rigidBody.velocity = velocity;
    }
}
