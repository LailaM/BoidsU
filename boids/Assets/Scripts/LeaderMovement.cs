using UnityEngine;
using System.Collections;

public class LeaderMovement : MonoBehaviour {

	private NavMeshAgent agent;
	private Vector3 goal;
	private GameObject [] waypoints;
	private int point;

	public static bool arrived;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		goal = transform.position;
		waypoints = GameObject.FindGameObjectsWithTag("WayPoint");
		point = Random.Range(0, waypoints.Length - 1);
		print(waypoints.Length - 1);
	}

	// Update is called once per frame
	void Update () {

		//print (point);
		goal = waypoints[point].transform.position;
		agent.SetDestination(goal);

		if(agent.remainingDistance == 0 ){
			//arrived = true;
			if(point < waypoints.Length - 1){
				//
				point += 1;
			}
			else{
				//print(point);
				point = 0;
			}

			print(point);
		}

	

	}
}
