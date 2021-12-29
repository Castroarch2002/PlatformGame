using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    Text myText;
    public int score = 0;

    void Start()
    {
        //Text sets your text to say this message
        myText = GetComponent<Text>();
        myText.text = "Score: " + score;
    }

    void Update()
    {
        myText.text = "Score: " + score;
    }
}
