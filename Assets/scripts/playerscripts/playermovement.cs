using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float movementforce=5f;
    public float movementx;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveplayer();
    }
    public void moveplayer()
    {
        movementx=Input.GetAxisRaw("Horizontal");
        if(movementx==0)
        {
            anim.SetBool("walk",false);
        }
        else if(movementx==1)
        {
            
            anim.SetBool("walk",true);
            Vector3 newposition=new Vector3(movementforce*Time.deltaTime,0,0);
            transform.position+=newposition;
        }
    }
}
