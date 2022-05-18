using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplayController : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public CoinCollector coinCollector;
    public GameObject winMessage;

    private int totalCoinsCount;
    
    // Start is called before the first frame update
    void Start()
    {
        winMessage.SetActive(false);
        var allCoins = FindObjectsOfType<CoinTag>(); // Returns array of object , var figures it out
        totalCoinsCount = allCoins.Length;
    }

    // Update is called once per frame
    void Update()
    {
        //textComponent.text = coinCollector.collectedCoinsCount.ToString() + " " + totalCoinsCount; // Convert int into String
        textComponent.text = $"Coins {coinCollector.collectedCoinsCount}/{totalCoinsCount}"; // Better performace
        bool isGameFinished = coinCollector.collectedCoinsCount >= totalCoinsCount;
        if (isGameFinished)
        {
            winMessage.SetActive(true);
        }
    }
}
