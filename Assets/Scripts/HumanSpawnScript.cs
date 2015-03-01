using UnityEngine;
using System.Collections;

public class HumanSpawnScript : MonoBehaviour {
	public float spawnTimer;
	private float timerAux;
	public GameObject humanSprite;

	void Start () {
	
	}
	
	void Update () {
		if (timerAux > spawnTimer) {
			GameObject humano = Instantiate(humanSprite, transform.position, Quaternion.identity) as GameObject;
			timerAux = 0;
		} else {
			timerAux += Time.deltaTime;
		}
	}
}
