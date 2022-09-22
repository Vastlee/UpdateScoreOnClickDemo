using UnityEngine;
using UnityEngine.EventSystems;

public class ScoreableObject : MonoBehaviour, IPointerClickHandler {
    [SerializeField] ScoreManager managerOfScores;

    public void OnPointerClick(PointerEventData eventData) {
        managerOfScores.ChangeScoreBy(1);
    }
}
