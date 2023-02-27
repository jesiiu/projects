using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public ParticleSystem explosion;
    public Text points;
    public Text gameOver;
    public Lives hearthPrefab;
    public float respawnTime = 3.0f;
    public float respawnInvTime = 3.0f;
    public int score = 0;
    public int lives = 3;

    public void Awake()
    {
        points.text = "0";
        hearthPrefab.GenerateHearths(lives);
    }
    public void AsteroidDestroyed(Asteroid asteroid)
    {
        this.explosion.transform.position = asteroid.transform.position;
        this.explosion.Play();
        Scoring();
    }

    public void PlayerDied()
    {
        this.explosion.transform.position = this.player.transform.position;
        this.explosion.Play();
        this.lives--;
        hearthPrefab.SubstractHearth();
        if (this.lives <= 0)
        {
            GameOver();
        }
        else
        {
            Invoke(nameof(Respawn), this.respawnTime);
        }
    }
    private void Respawn()
    {
        this.player.transform.position = Vector3.zero;
        this.player.gameObject.layer = LayerMask.NameToLayer("IgnoreCollisions");
        this.player.gameObject.SetActive(true);
        Invoke(nameof(TurnOnCollisions), respawnInvTime);
    }
    private void TurnOnCollisions()
    {
        this.player.gameObject.layer = LayerMask.NameToLayer("Player");
    }
    private void GameOver()
    {

        gameOver.text = "GAME OVER";
        Time.timeScale = 0.5f;
    }
    private void Scoring()
    {
        score++;
        points.text = score.ToString();
    }
    
}
