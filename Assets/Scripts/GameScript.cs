using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {
	public GameObject movedora, firePower;
	private RaycastHit hit;
	private int powerID = 0;

	void Start () {
	
	}

	void Update () {
		#if UNITY_ANDROID && !UNITY_EDITOR
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began){
			Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch (0).position);
			
			#elif UNITY_EDITOR
			if (Input.GetMouseButtonDown (0)) {
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				
			#endif
			
			if (Physics.Raycast(ray, out hit)){
				switch(powerID){
				case 0:
					normalTouch();
					break;
				case 1:
					fireTouch();
					break;
				}
			}
		}
	}

	void normalTouch(){
		GameObject moveSphere = Instantiate (movedora, hit.point, Quaternion.identity) as GameObject;
	}

	void fireTouch(){
		GameObject moveSphere = Instantiate (firePower, hit.point, Quaternion.identity) as GameObject;
	}

	public void botones(int ID){
		if (ID == powerID)
			powerID = 0;
		else
			powerID = ID;
	}
}
