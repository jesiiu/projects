using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public Text playerScoreText;
    public Text computerScoreText;
    public Text pauseText;
    
    private int _playerScore;
    private int _computerScore;
    public static bool isGamePaused = false;
    
    public void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                ResumeGame();
            }
            else
            {
            PauseGame();
            }
        }
        
    }

    public void PlayerScores()
    {
        _playerScore++;
        ResetRound();
    }

    public void ComputerScore()
    {
        _computerScore++;
        ResetRound();
    }
    public void ResetRound()
    {
        this.playerScoreText.text = _playerScore.ToString();
        this.computerScoreText.text = _computerScore.ToString();
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
    public void ResumeGame()
    {
        this.pauseText.text = null;
        Time.timeScale = 1f;
        isGamePaused = false;
    }
    public void PauseGame()
    {
        this.pauseText.text = "Game paused";
        Time.timeScale = 0f;
        isGamePaused = true;
    }
}
