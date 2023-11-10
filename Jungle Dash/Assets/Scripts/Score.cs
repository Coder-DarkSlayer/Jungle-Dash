using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scoreValue = 0;
    public Text score;
    void Start()
    {
        score = GetComponent<Text>();
    }
    // public void

    void Update()
    {
        score.text = scoreValue.ToString();
    }
}
