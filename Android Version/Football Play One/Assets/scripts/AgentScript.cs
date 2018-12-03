using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Diagnostics;

public class AgentScript : MonoBehaviour {


    
    //PRESS SPACE TO MOVE THE PLAYERS

    public Vector3 targetPositionOne;
    public Vector3 targetPositionTwo;
    public NavMeshAgent agent;
    bool second = false;

   
    Stopwatch sw = new Stopwatch();

	// Use this for initialization
	void Start ()
    {
        sw.Start();
        agent = GetComponent<NavMeshAgent>();
	}

    // Update is called once per frame
	void Update ()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            agent.SetDestination(targetPositionOne);
        }

        if (agent.transform.position == targetPositionOne)
            second = true;


        if (Input.GetKey(KeyCode.UpArrow))
            agent.SetDestination(targetPositionTwo);


      

       
        

	}


    public void firstPostition()
    {
        agent.SetDestination(targetPositionOne);
    }


    public void secondPosition()
    {
        agent.SetDestination(targetPositionTwo);
        
    }
}
