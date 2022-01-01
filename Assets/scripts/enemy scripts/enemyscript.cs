using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    private float speed=3;
    public GameObject[] enemies;
    public GameObject enemyone;
    public GameObject enemytwo;
    public GameObject enemythree;
    // Start is called before the first frame update
    void Start()
    {
        enemies[0].transform.position=new Vector3(-2,0,0);
        enemyone= Instantiate(enemies[0]);
        enemyone.tag="enemy";
        enemies[1].transform.position=new Vector3(-5,0,0);
        enemytwo= Instantiate(enemies[1]);
        enemytwo.tag="enemy";
        enemies[2].transform.position=new Vector3(-10,0,0);
        enemythree= Instantiate(enemies[2]);
        enemythree.tag="enemy";
    }

    // Update is called once per frame
    void Update()
    {
        enemyone.transform.position+=new Vector3(speed*Time.deltaTime,0,0);
        enemytwo.transform.position+=new Vector3(speed*Time.deltaTime,0,0);
        enemythree.transform.position+=new Vector3(speed*Time.deltaTime,0,0);
    }
}
