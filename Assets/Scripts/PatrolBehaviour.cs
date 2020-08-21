using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolBehaviour : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float moveSpeed;
    public int currPoint;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = patrolPoints[0].position;
	currPoint = 0;
	moveSpeed = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
	int prev = currPoint;
        if(transform.position == patrolPoints[currPoint].position){
		currPoint++;
		currPoint%=patrolPoints.Length;
	}
	
	transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currPoint].position, moveSpeed);;
    }
}
