using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		
		if (other.gameObject.tag == "Player1" || other.gameObject.tag == "Player2") 
		{ 
			Destroy (other.gameObject);
		} 
		
	}
}
