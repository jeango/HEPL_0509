using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    public TMP_Text scoreText;

    void Update()
    {
        scoreText.text = GameManager.score.ToString();
    }
}