using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    private float movementforce = 5f;
    private float movementx;
    private float movementy;
    private Animator anim;
    private Rigidbody2D body;
    private SpriteRenderer sptrnd;
    // Start is called before the first frame update
    void Start()
    {
        sptrnd = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveplayer();
    }
    public void moveplayer()
    {
        movementx = Input.GetAxisRaw("Horizontal");
        // Debug.Log(movementy);
        if (movementx == 0)
        {
            anim.SetBool("walk", false);
        }
        else if (movementx == 1)
        {
            if (transform.position.x <= 93)
            {
                sptrnd.flipX = false;
                anim.SetBool("walk", true);
                Vector3 newposition = new Vector3(movementforce * Time.deltaTime, 0, 0);
                transform.position += newposition;
            }
            else
            {
                anim.SetBool("walk", false);
            }
        }
        else if (movementx == -1)
        {
            if (transform.position.x >= -81)
            {
                anim.SetBool("walk", true);
                sptrnd.flipX = true;
                Vector3 newposition = new Vector3(movementforce * Time.deltaTime, 0, 0);
                transform.position -= newposition;
            }
            else
            {
                anim.SetBool("walk",false);
            }

        }
        if (Input.GetKeyDown("space"))
        {
            if (!anim.GetBool("jump"))
            {
                anim.SetBool("jump", true);
                body.AddForce(new Vector2(0, 500));
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            anim.SetBool("jump", false);
        }
        if(other.gameObject.tag=="enemy")
        {
            Debug.Log("game over");
        }
    }
}
