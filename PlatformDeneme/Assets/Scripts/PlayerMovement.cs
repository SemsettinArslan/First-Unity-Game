using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    private InputManager inputManager;
    private float moveSpeed = 4.1f;
    private float jumpForce = 5.2f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private bool isJumping;
    public Animator animator;

    private void Awake()
    {
        inputManager = new InputManager();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        inputManager.Player.Enable();
        inputManager.Player.Movement.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        inputManager.Player.Movement.canceled += ctx => moveInput = Vector2.zero;
        inputManager.Player.Jump.performed += ctx => isJumping=true;
    }

    private void OnDisable()
    {
        inputManager.Player.Disable();
    }

    private void FixedUpdate()
    {
        if (isJumping)
        {
            Jump();
            isJumping = false;
        }
        Move();
    }
    //Karakter haraket metodu
    private void Move()
    {
        rb.velocity = new Vector2(moveInput.x * moveSpeed, rb.velocity.y);
        //Karakterin Run animasyonuna geçiþi
        animator.SetFloat("Speed",MathF.Abs( rb.velocity.x));
        //Karakterin baktýðý yönü deðiþtirme
        if (moveInput.x < 0)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f); // Sola bak
        }
        else if (moveInput.x > 0)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f); // Saða bak
        }
    }
    //Karakter zýplama metodu
    private void Jump()
    {
            if (Mathf.Abs(rb.velocity.y) < 0.01f&& !animator.GetBool("IsJumping"))
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                animator.SetBool("IsJumping", true);
            }
    }

    // Jump Animasyon kontrolu
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            animator.SetBool("IsJumping", false);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            animator.SetBool("IsJumping", true);
        }
    }

}
