using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    [ContextMenu("Increase Score")]
    public void addScore(int score){
        playerScore += score;
        scoreText.text = playerScore.ToString();
    }
}
