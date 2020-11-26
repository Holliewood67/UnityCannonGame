using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI enemyScoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdatPlayerScoreText (int score)
    {
        playerScoreText.text = "Player Score: " + score.ToString();
    }

    public void UpdateEnemyScoreText (int score)
    {
        enemyScoreText.text = "Enemy Score: " + score.ToString();
    }
}
