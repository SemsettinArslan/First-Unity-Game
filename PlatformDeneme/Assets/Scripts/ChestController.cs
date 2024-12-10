using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    Animator animator;
    public GameObject finishMenu;
    public GameObject pauseButton;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    //Karakter chest hitboxuna gelince chest animasyonunu oynatma.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            animator.SetBool("Check", true);
        }
    }
    public void ShowFinishMenu()
    {
            Time.timeScale = 0;
            finishMenu.SetActive(true);
            pauseButton.SetActive(false);
    }
}
