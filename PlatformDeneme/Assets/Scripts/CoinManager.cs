using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    private int coinCount;
    public TextMeshProUGUI coinText;
    private DoTweenHandler tweenHandler;
    //Coin miktar�n� artt�rma
    public void addCoins(int count)
    {
        coinCount += count;
        textUpdate();
    }
    //Coin yaz�s�n� g�ncelleme.
    void textUpdate()
    {
        coinText.text = "x" + coinCount.ToString();
        tweenHandler.textTween(coinText);
    }

    public void Start()
    {
        tweenHandler =GetComponent<DoTweenHandler>();
        textUpdate();
    }

}
