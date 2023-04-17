using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    private float dirX = -1f;
    [SerializeField] private float moveSpeed = 1f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        this.gameObject.transform.localScale = new Vector3(-1,1,1); //Vira o sprite para esquerda para não
                                                                    //ter que ficar arrumando na porra da unity lá
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Tower")    //Se colidiu com a tag Tower para de se mover
        {
            dirX = 0f;
        }
    }

    void Update()
    {
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
    }
}
