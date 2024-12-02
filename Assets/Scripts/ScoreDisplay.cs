using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text hiScoreText;

    void Update()
    {
        scoreText.text = GameManager.score.ToString();
        hiScoreText.text = GameManager.hiScore.ToString();
    }
}