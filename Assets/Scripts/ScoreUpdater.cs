using TMPro;
using UnityEngine;

public class ScoreUpdater : MonoBehaviour {
    [SerializeField] ScoreManager managerOfScores;
    [SerializeField] TMP_Text scoreText;

    void Start() => managerOfScores.SetScore(0);
    void OnEnable() => managerOfScores.OnScoreChange += ChangeScore;
    void OnDisable() => managerOfScores.OnScoreChange -= ChangeScore;

    private void ChangeScore(int newScore) =>
        scoreText.text = newScore.ToString();

}
