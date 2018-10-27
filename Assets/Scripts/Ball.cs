using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private Rigidbody rigidBody;
    public float speed = 2f;

    public Vector3 velocity;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
        velocity = new Vector3(speed, speed);

        rigidBody.velocity = velocity;
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
}
