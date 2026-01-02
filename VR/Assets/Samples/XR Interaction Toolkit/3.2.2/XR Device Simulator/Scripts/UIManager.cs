using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public Text bestScoreText;

    private int moneteRaccolte;

    void Start()
    {
        int bestScore = PlayerPrefs.GetInt("BestScore", 0);
        bestScoreText.text = "Best: " + bestScore;

        moneteRaccolte = 0;
        scoreText.text = "Score: " + moneteRaccolte;
    }

    public void UpdateScore()
    {
        moneteRaccolte++;
        scoreText.text = "Score: " + moneteRaccolte;

        int bestScore = PlayerPrefs.GetInt("BestScore", 0);
        if (moneteRaccolte > bestScore)
        {
            PlayerPrefs.SetInt("BestScore", moneteRaccolte);
            PlayerPrefs.Save();
            bestScoreText.text = "Best: " + moneteRaccolte;
        }
    }
}