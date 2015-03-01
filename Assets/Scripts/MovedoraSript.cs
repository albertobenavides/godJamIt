using UnityEngine;
using System.Collections;

public class MovedoraSript : MonoBehaviour {

	void Update () {
		if (transform.localScale.x < 5)
			transform.localScale += new Vector3 (Time.deltaTime * 15, Time.deltaTime * 15, Time.deltaTime * 15);
		else
			Destroy (this.gameObject);
	}
}
