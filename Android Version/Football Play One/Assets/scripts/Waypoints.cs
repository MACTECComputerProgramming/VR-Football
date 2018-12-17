﻿using System.Collections;
using UnityEngine;

public class Waypoints : MonoBehaviour {

    
    public GameObject[] waypoints;

    
    public int num = 0;

    public bool correct;

    //set to 0.5 or 1 
    public float minDist;
    public float speed;

    public bool rand = false;
    public bool go = false;


    
    
    void Start () 
    {
    
       

	}
	
	
	void Update () 
    {

        float dist = Vector3.Distance(gameObject.transform.position, waypoints[num].transform.position);

        if(go)
        {
            if (dist > minDist)
            {
                Move();
            }
            else
            {
                if (!rand)
                {
                    if(num + 1 == waypoints.Length)
                    {
                        num=0;
                    }
                    else
                    {
                        num++;
                    }
                }else
                {
                    num = Random.Range(0, waypoints.Length);
                }
            }


        }

	}

    public void Move()
    {
        gameObject.transform.LookAt(waypoints[num].transform.position);
        gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime;

    }



}
