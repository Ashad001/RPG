using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private BoxCollider2D PlayerCollider;
    private Vector3 move;
    private RaycastHit2D Hit;

    // Start is called before the first frame update
    void Start()
    {
        PlayerCollider = GetComponent<BoxCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        move = new Vector3(x, y, 0);

        if (move.x < 0)
            transform.localScale = new Vector3(-1, 1, 1);
        else if (move.x > 0)
            transform.localScale = Vector3.one;

        Hit = Physics2D.BoxCast(transform.position, PlayerCollider.size, 0, new Vector2(0, move.y), Mathf.Abs(move.y * Time.deltaTime), LayerMask.GetMask("Character", "Blocking"));
        if(Hit.collider == null)
        {
            transform.Translate(0, move.y * Time.deltaTime, 0);
        }
        Hit = Physics2D.BoxCast(transform.position, PlayerCollider.size, 0, new Vector2(move.x, 0), Mathf.Abs(move.x * Time.deltaTime), LayerMask.GetMask("Character", "Blocking"));
        if (Hit.collider == null)
        {
            transform.Translate(move.x * Time.deltaTime, 0 ,0);
        }

    }
}
