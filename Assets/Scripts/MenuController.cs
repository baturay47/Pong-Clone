using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public Button playButton;

    public Slider ballsizeSlider;
    public Text ballsizeText;

    public Slider ballspeedSlider;
    public Text ballspeedText;

    public Slider padsizeSlider;
    public Text padsizeText;

    public Slider padspeedSlider;
    public Text padspeedText;

    // Use this for initialization
    void Start () {
        playButton.onClick.AddListener(StartGame);

        ballsizeSlider.onValueChanged.AddListener(delegate { BallSizeChecker(); });
        ballspeedSlider.onValueChanged.AddListener(delegate { BallSpeedChecker(); });
        padsizeSlider.onValueChanged.AddListener(delegate { PadSizeChecker(); });
        padspeedSlider.onValueChanged.AddListener(delegate { PadSpeedChecker(); });

    }
	
	// Update is called once per frame
	void Update () {

    }

    void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    void BallSizeChecker()
    {
        ballsizeText.text = ValueMatcher((int)ballsizeSlider.value);
    }

    void BallSpeedChecker()
    {
        ballspeedText.text = ValueMatcher((int)ballspeedSlider.value);
    }

    void PadSizeChecker()
    {
        padsizeText.text = ValueMatcher((int)padsizeSlider.value);
    }

    void PadSpeedChecker()
    {
        padspeedText.text = ValueMatcher((int)padspeedSlider.value);
    }

    private string ValueMatcher(int value)
    {
        switch(value)
        {
            case 0:
                return "small";
            case 1:
                return "medium";
            case 2:
                return "large";
            default:
                return "N/A";
        }
    }
}
