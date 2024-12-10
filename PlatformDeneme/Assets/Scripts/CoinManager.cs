using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    private int coinCount;
    public TextMeshProUGUI coinText;
    private DoTweenHandler tweenHandler;
    //Coin miktarýný arttýrma
    public void addCoins(int count)
    {
        coinCount += count;
        textUpdate();
    }
    //Coin yazýsýný güncelleme.
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
