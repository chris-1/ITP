using UnityEngine;
using System.Collections;

public class FireUpScript : MonoBehaviour {


	void OnTriggerEnter(Collider other) {

		if (other.gameObject.tag == "Player1") 
		{ 
			Player1.explosionLevel++;
			Destroy (this.gameObject);
		} 
		else if (other.gameObject.tag == "Player2") 
		{ 
			Player2.explosionLevel++;
			Destroy (this.gameObject);
		} 
		
	}

}
