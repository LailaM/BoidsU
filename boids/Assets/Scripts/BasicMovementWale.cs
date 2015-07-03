using UnityEngine;
using System.Collections;

public class BasicMovementWale: MonoBehaviour {

	private NavMeshAgent agent;
	private GameObject leaderPos;
	
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		leaderPos = GameObject.FindGameObjectWithTag("LeaderWale");
		//print (leaderPos.position);

		//print (leaderPos.transform.position);

		agent.SetDestination(leaderPos.transform.position);

	}
}
