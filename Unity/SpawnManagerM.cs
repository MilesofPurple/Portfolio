using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpawnManagerM : MonoBehaviour
{

    public GameObject[] enemies;
    public GameObject[] friendlies;
    public GameObject powerup;

    private float zEnemySpawn = 20.0f;
    private float xSpawnRange = 23.0f;
    private float zFriendlySpawn = 10.0f;
    private float xFriendlySpawn = 23.0f;
    private float zPowerupRange = 17.0f;
    private float ySpawn = .50f;

    private float powerupSpawnTime = 10.0f;
    private float enemySpawnTime = 6.0f;
    private float friendlySpawnTime = 6.0f;
    private float startDelay = 1.0f;
    public int score;
    public int pointValue;
    float currentTime = 999.0f;
    float startingTime = 60.0f;
    public bool isGameActive;
    public bool gameOver;
    public float difficultyModifier = 0.0f;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public GameObject titleScreen;
    private SpawnManagerM spawnManagerM;
    //private PlayerControllerM playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        //playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerM>();
    }

    public void StartGame(int difficulty)
    {
        currentTime = startingTime;
        gameOver = false;
        isGameActive = true;
        score = 0;
        titleScreen.gameObject.SetActive(false);

        if (gameOver == false && isGameActive == true)
        {
            InvokeRepeating("SpawnRandomEnemy", startDelay, enemySpawnTime - difficulty);
            InvokeRepeating("SpawnPowerup", startDelay, powerupSpawnTime + difficulty);
            InvokeRepeating("SpawnRandomFriendly", startDelay, friendlySpawnTime - difficulty);
            UpdateScore(0);
        }
        else
        {
            startDelay = 10000;
        }
    }


    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        titleScreen.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameActive = false;
        gameOver = true;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timerText.text = "Time: " + currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            GameOver();
            Debug.Log("Game Over!");
        }
    }

    void SpawnRandomEnemy()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        int randomIndex = Random.Range(0, enemies.Length);
        
        Vector3 spawnPos = new Vector3(randomX, ySpawn, zEnemySpawn);

        Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
    }

    void SpawnRandomFriendly()
    {
        float randomZ = Random.Range(-zFriendlySpawn, zFriendlySpawn);
        int randomIndex = Random.Range(0, friendlies.Length);

        Vector3 spawnPos = new Vector3(xFriendlySpawn, ySpawn, randomZ);

        Instantiate(friendlies[randomIndex], spawnPos, friendlies[randomIndex].gameObject.transform.rotation);
    }

    void SpawnPowerup()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        float randomZ = Random.Range(-zPowerupRange, zPowerupRange);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, randomZ);

        Instantiate(powerup, spawnPos, powerup.gameObject.transform.rotation);
    }
}
