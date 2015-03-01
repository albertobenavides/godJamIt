using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameScript : MonoBehaviour {
	public GameObject movedora, firePower, padre;
	private RaycastHit hit;
	private int powerID = 0;
	public Button[] powerButs;

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
		Vector3 firePos = new Vector3 (hit.point.x, hit.point.y , hit.point.z);
		GameObject fire = Instantiate (firePower, firePos, Quaternion.identity) as GameObject;
		fire.transform.parent = padre.transform;
	}

	public void botones(int ID){
		if (ID == powerID) {
			powerButs[ID-1].GetComponent<Image>().color = Color.white;
			powerID = 0;
		} else {
			powerID = ID;
			powerButs[ID-1].GetComponent<Image>().color = Color.green;
		}
	}
}
