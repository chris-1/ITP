using UnityEngine;
using System.Collections;

public class DestroyPowerUp : MonoBehaviour {
	private Vector3 currentPosition;
	private string test_tag;
	private GameObject obj;


	void Awake () {
		currentPosition = transform.position;
		
		
	}

	void OnDestroy(){

		foreach (var col in Physics.OverlapSphere (currentPosition, 0.1f)) {
						test_tag = col.gameObject.tag;
						obj = col.gameObject;


						if (test_tag == "PowerUp") {
								Destroy (obj);		
				break;
						}
				}
	}
		

}
