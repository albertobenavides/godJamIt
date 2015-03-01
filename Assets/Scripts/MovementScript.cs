using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {
	private int direction;
	public float timerDirection, speed;
	private float timerAux;

	void Start(){
		timerDirection = Random.Range (3,10);
		direction = Random.Range (0,4);
		addMovement();
	}

	void Update () {
		if (timerAux > timerDirection) {
			direction = Random.Range (0,4);
			rigidbody.velocity = Vector3.zero;
			addMovement();
			timerAux = 0;
			timerDirection = Random.Range (3,10);
		} else {
			timerAux += Time.deltaTime;
		}
	}

	void addMovement(){
		switch (direction) {
		case 0:
			rigidbody.velocity = transform.forward * speed;
			break;
		case 1:
			rigidbody.velocity = -transform.forward * speed;
			break;
		case 2:
			rigidbody.velocity = transform.right * speed;
			break;
		case 3:
			rigidbody.velocity = -transform.right * speed;
			break;
		}
	}
}
