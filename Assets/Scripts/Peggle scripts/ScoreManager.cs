using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Singleton
    public static ScoreManager Instance;

    // Totale score
    public int score = 0;
    [SerializeField] public TMP_Text Points;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        UpdatePointsText();
    }

    public void AddScore(int amount)
    {
        score = score + amount;
        UpdatePointsText();
    }

    private void UpdatePointsText()
    {
        if (Points != null)
        {
            Points.text = "Score: " + score.ToString();
        }
    }
}
