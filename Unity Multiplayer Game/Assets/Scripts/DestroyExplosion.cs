using UnityEngine;
using System.Collections;

public class DestroyExplosion : MonoBehaviour {
	
	void Start () {

		StartCoroutine (destroyExplosion ());


	}

	IEnumerator destroyExplosion(){

		yield return new WaitForSeconds(1f);
		Destroy (this.gameObject);


	}

}
