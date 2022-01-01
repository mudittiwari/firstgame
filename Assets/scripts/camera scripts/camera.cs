using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        // Debug.Log(player.transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x <= 85 && player.transform.position.x>=-73)
        {
            Vector3 temp = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
            transform.position = temp;
        }
    }
}
