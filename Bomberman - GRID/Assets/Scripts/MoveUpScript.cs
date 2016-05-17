using UnityEngine;
using System.Collections;

public class MoveUpScript : MonoBehaviour {


	void OnTriggerEnter(Collider other) {
		 
		if (other.gameObject.tag == "Player1") 
		{ 
			Player1.moveSpeed += 0.5f;
			Destroy (this.gameObject);
		} 
		else if (other.gameObject.tag == "Player2") 
		{ 
			Player2.moveSpeed += 0.5f;
			Destroy (this.gameObject);
		} 
	}

}
