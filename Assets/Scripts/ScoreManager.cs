using System;
using UnityEngine;

[CreateAssetMenu(fileName = "ScoreManager", menuName = "ScriptableObjects/ScoreManager")]
public class ScoreManager : ScriptableObject {
    [field: SerializeField] public int CurrentScore { get; private set; }

    public event Action<int> OnScoreChange;

    public void SetScore(int newScore) {
        CurrentScore = newScore;
        OnScoreChange?.Invoke(CurrentScore);
    }

    public void ChangeScoreBy(int changeBy) {
        CurrentScore += changeBy;
        OnScoreChange?.Invoke(CurrentScore);
    }
}
