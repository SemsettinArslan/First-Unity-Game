using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //Player coin ile etkileþime geçince coini yok etme.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            AudioManager.Instance.Play("PickUpCoin");
            FindObjectOfType<CoinManager>().addCoins(1);
            Destroy(gameObject);
            
        }
    }

}
