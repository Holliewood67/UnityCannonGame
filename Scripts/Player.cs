using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public PlayerMissile playerMissle;
    public PlayerTarget playerTarget;

    public ScoreUI scoreUI;
    public RoundOverScreen roundOverScreen;

    public int playerScore = 0;
    public int enemyScore = 0;
    private int playerCoins;
    private int coinGain;
    
    public TextMeshProUGUI roundOverText;
    public TextMeshProUGUI currentCoinsText;
    public TextMeshProUGUI coinsEarnedText;
    public TextMeshProUGUI timerText;

    void Awake()
    {
        if (PlayerPrefs.HasKey("coinsPref"))
        {
            playerCoins = PlayerPrefs.GetInt("coinsPref");
            Debug.Log(PlayerPrefs.GetInt("coinsPref").ToString());
        }
        else 
        {
            Debug.Log("You are a broke ass bitch and you need some moneys.");    
        }
    }

    public void Fire ()
    {
        PlayerMissile playerMissileInstance = Instantiate(playerMissle);
        playerMissileInstance.Launch(playerTarget);
        StartCoroutine(DetermineWinner());
    }

    public void AddScore (int boxValue)
    {
        playerScore = playerScore + boxValue;
        scoreUI.GetComponent<ScoreUI>().UpdatPlayerScoreText(playerScore);
    }

    public void AddEnemyScore(int boxValue)
    {
        enemyScore = enemyScore + boxValue;
        scoreUI.GetComponent<ScoreUI>().UpdateEnemyScoreText(enemyScore);
    }


    private IEnumerator DetermineWinner()
    {
        int timer = 10;
        while (timer >= 0)
        {
            timerText.text = timer.ToString();
            timer--;
            yield return new WaitForSeconds(1);
        }

        

        if (playerScore > enemyScore)
        {
            Debug.Log("You win!");
            roundOverText.text = "You Win!";
            coinGain = (playerScore - enemyScore);
            playerCoins += coinGain;
            PlayerPrefs.SetInt("coinsPref", playerCoins);
            PlayerPrefs.Save();
            coinsEarnedText.text = "You Earned " + coinGain + " Coins";
        } 
        else if (playerScore < enemyScore)
        {
            Debug.Log("You Lose!");
            roundOverText.text = "You Lose!";
            coinsEarnedText.text = "";
        }

        currentCoinsText.text = "You have " + playerCoins + " Coins";
        roundOverScreen.gameObject.SetActive(true);
    }

    public void OnRestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ReturnToMenu ()
    {
        SceneManager.LoadScene(0);
    }
}
