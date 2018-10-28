using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player : MonoBehaviour {

    protected float upperLimit;
    protected float lowerLimit;

    public float padSpeed;

    protected void LoadPrefsandInit()
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

        upperLimit = 4.75f - transform.localScale.x / 2;
        lowerLimit = -upperLimit;
    }
}
