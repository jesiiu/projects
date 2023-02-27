using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text _startText;
    private bool gameStatus = false;
    private bool gameStarted = false;
    public float _snakeSpeed = 1f;

    public void Awake()
    {
        Time.timeScale = 0f;
    }

    private void Update()
    {
        GameControll();
    }

    private void GameControll()
    {
        if(gameStatus == false && gameStarted == false)
        {
            Time.timeScale = 0f;
            _startText.text = "Press any button to start game";
            if(Input.anyKey)
            {
                _startText.text = string.Empty;
                Time.timeScale = _snakeSpeed;
                gameStarted = true;
                gameStatus = true;
            }
        }
        
        else if (gameStatus == true && gameStarted == true)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Time.timeScale = 0f;
                _startText.text = "Game paused";
                gameStatus = false;
            }
        }
        else if (gameStatus == false && gameStarted == true)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Time.timeScale = _snakeSpeed;
                _startText.text = string.Empty;
                gameStatus = true;
            }
        }

    }
}
