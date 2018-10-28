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
        PlayerPrefs.SetInt("ballSize", (int)ballsizeSlider.value);
        PlayerPrefs.SetInt("ballSpeed", (int)ballspeedSlider.value);
        PlayerPrefs.SetInt("padSize", (int)padsizeSlider.value);
        PlayerPrefs.SetInt("padSpeed", (int)padspeedSlider.value);
        SceneManager.LoadScene("Game");
    }

    void BallSizeChecker()
    {
        ballsizeText.text = SizeValueMatcher((int)ballsizeSlider.value);
    }

    void BallSpeedChecker()
    {
        ballspeedText.text = SpeedValueMatcher((int)ballspeedSlider.value);
    }

    void PadSizeChecker()
    {
        padsizeText.text = SizeValueMatcher((int)padsizeSlider.value);
    }

    void PadSpeedChecker()
    {
        padspeedText.text = SpeedValueMatcher((int)padspeedSlider.value);
    }

    private string SizeValueMatcher(int value)
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

    private string SpeedValueMatcher(int value)
    {
        switch (value)
        {
            case 0:
                return "slow";
            case 1:
                return "normal";
            case 2:
                return "fast";
            default:
                return "N/A";
        }
    }
}
