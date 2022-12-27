using UnityEngine;

using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public int score;
    void Start()
    {
        score = 0;
    }

    public void AddScore(int addendum)
    {
        score += addendum;
        scoreText.text = "Score: " + score;
    }

    void GameObjectDeletedByOutOfMap(GameObject deletedObject)
    {
        if (deletedObject.CompareTag("Meteor"))
        {
            AddScore(1);
        }
    }
}
