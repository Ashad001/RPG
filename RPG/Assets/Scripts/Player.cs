using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private BoxCollider2D PlayerCollider;
    private Vector3 move;

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

        transform.Translate(move * Time.deltaTime);
    }
}
