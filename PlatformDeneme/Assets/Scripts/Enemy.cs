using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject restartMenu;

    //Player d��mana hitboxu ile etkile�ime ge�erse oyunu durdurma.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            restartMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            restartMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

}
