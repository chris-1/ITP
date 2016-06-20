using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {
    //public GameObject otherObj;

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
        if (other.gameObject.tag == "Wall")
        {
            
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "Box")
        {
            other.GetComponent<BoxScript>().spawnItem();
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }

    }

}
