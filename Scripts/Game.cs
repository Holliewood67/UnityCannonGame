using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Game : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject shopMenu;

    public TextMeshProUGUI currentCoinsText;

    private int playerCoins;

    private void Start()
    {
        playerCoins = PlayerPrefs.GetInt("coinsPref");
    }

    private void Update()
    {
        currentCoinsText.text = "You currently have " + playerCoins + " coins.";
    }

    public void StartClassicMode ()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenShop ()
    {
        mainMenu.gameObject.SetActive(false);
        shopMenu.gameObject.SetActive(true);

    }

    public void SpendCoins (int amountToSpend)
    {
        playerCoins = playerCoins - amountToSpend;
        PlayerPrefs.SetInt("coinsPref", playerCoins);
        PlayerPrefs.Save();
    }

    public void ReturnToMenu ()
    {
        shopMenu.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
    }
}
