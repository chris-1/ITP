using UnityEngine;
using System.Collections;

public class BombUpScript : MonoBehaviour {


	void OnTriggerEnter(Collider other) {

		if (other.gameObject.tag == "Player1") 
		{ 
			Player1.bombLevel++;
			Destroy (this.gameObject);
		} 
		else if (other.gameObject.tag == "Player2") 
		{ 
			Player2.bombLevel++;
			Destroy (this.gameObject);
		} 
	}

}
