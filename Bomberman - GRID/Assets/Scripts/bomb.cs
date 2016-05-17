using UnityEngine;
using System.Collections;

public class bomb : MonoBehaviour {
	
	float detonateTime = 3f;
	public GameObject explosionBomb;
	
	void Start () {
		StartCoroutine (destroyBomb());
	}
	
	void OnTriggerExit (Collider other) {

		if (other.tag == "Player1" || other.tag == "Player2") {

			gameObject.GetComponent<Collider>().isTrigger = false;
		}
	}
	
	IEnumerator destroyBomb() {

		yield return new WaitForSeconds(detonateTime);
		Destroy (this.gameObject);
		Instantiate (explosionBomb, transform.position, Quaternion.identity);
	}

	void OnDestroy(){
		Player1.bombCount--;
	}
}
