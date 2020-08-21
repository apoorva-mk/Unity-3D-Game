using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private float moveSpeed;
    public GameObject explosion;
    private Vector3 spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 0.1f;
	spawnPosition = transform.position;
	print("hi");
	//spawnPosition = tranform.position;
    }

    // Update is called once per frame
    void Update()
    {
	// print(Input.GetAxis("Horizontal"));
        transform.Translate(moveSpeed*Input.GetAxis("Horizontal"), 0f, moveSpeed*Input.GetAxis("Vertical"));
	if(transform.position.y < -7){
		GameOver();
	}
    }

    void OnCollisionEnter(Collision other){
    	
	if(other.gameObject.tag == "Enemy") {
		GameOver();
	}
    }

    void OnTriggerEnter (Collider other){
	if(other.gameObject.tag == "Goal"){
		GameManager.OnCompleteLevel();
	}
    }

    void GameOver(){
	Instantiate(explosion, transform.position, Quaternion.identity);
	transform.position = spawnPosition;
    }
}
