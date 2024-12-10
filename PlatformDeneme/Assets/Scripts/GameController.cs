using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject restartMenu;
    public GameObject pauseButton;
    private Rigidbody2D rb;
    private int deathHeight = -20;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    //Karakter yüksekten düþtüðünde ölmesi için kontrol
    private void deathHeightPlayer()
    {
        if (rb.velocity.y <= deathHeight)
        {
            restartMenu.SetActive(true);
            pauseButton.SetActive(false);
            Time.timeScale = 0;
        }
    }
    private void FixedUpdate()
    {
        deathHeightPlayer();
    }
}
