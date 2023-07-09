using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad;
    private Rigidbody2D rb;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoHorizontal = Input.GetAxisRaw("Horizontal");
        MovementSystem(movimientoHorizontal);
        animator.SetFloat("Speed", Mathf.Abs(movimientoHorizontal));
        
    }
    public void MovementSystem(float x)
    {
        Vector3 playerInput = new Vector3 (x,0,0);
        rb.MovePosition(GetComponent<Transform>().position + playerInput* velocidad * Time.deltaTime);

    }
}
