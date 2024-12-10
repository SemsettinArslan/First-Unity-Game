using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaceController : MonoBehaviour
{
    public float dropSpeed = 2f;
    public float riseSpeed = 2f;
    public float maxDropDistance = 2.5f;
    private Vector3 startPosition;

    private bool isDropping = true;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        Drop();
    }
    //Mace yukarý ve aþaðý haraket metodu.
    private void Drop()
    {
        if (isDropping) 
        {
            transform.Translate(Vector3.down * dropSpeed * Time.deltaTime);

            if(Vector3.Distance(transform.position, startPosition) >= maxDropDistance)
            {
                isDropping = false;
            }
        }
        else
        {
            transform.Translate(Vector3.up*riseSpeed * Time.deltaTime);

            if (Vector3.Distance(transform.position, startPosition) <= 0.1f)
            {
                isDropping = true;
            }
        }


    }
}
