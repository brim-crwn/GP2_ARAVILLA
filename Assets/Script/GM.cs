using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GM : MonoBehaviour
{
    public static GM Instance { get; private set; }

    [SerializeField]
    private TMP_Text scoreText;

    private int score = 0;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        //DontDestroyOnLoad(gameObject);

    }

    // Once
    private void Update()
    {
        UpdateScoreUI();
    }

    public void AddScore(int value)
    {
        score += value;
        score = Mathf.Max(score, 0);
        Debug.Log($"[GM] Score changed by {value}. New score:{score}");
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {

            scoreText.text = "Score:" + score.ToString();
        }
    }
}