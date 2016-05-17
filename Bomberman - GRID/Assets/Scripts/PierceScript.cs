using UnityEngine;
using System.Collections;

public class PierceScript : MonoBehaviour {


	void OnTriggerEnter(Collider other) {
		
		if (other.gameObject.tag == "Player1") 
		{ 
			Player1.pierceState = true;
			Destroy (this.gameObject);
		} 
		else if (other.gameObject.tag == "Player2") 
		{ 
			Player2.pierceState = true;
			Destroy (this.gameObject);
		} 
		
	}

}
