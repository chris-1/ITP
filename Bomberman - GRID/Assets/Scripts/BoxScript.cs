using UnityEngine;
using System.Collections;

public class BoxScript : MonoBehaviour {
	private float rand;
	private Vector3 currentPosition;
	public GameObject FireUp;
	public GameObject FireUp2;
	public GameObject BombUp;
	public GameObject BombUp2;
	public GameObject MoveUp;
	public GameObject MoveUp2;
	public GameObject Pierce;
	public GameObject Pierce2;


	// Use this for initialization
	void Awake () {
		currentPosition = transform.position + new Vector3(0f,0.5f,0f);
        


    }

    void Start()
    {
        rand = (Random.Range(0F, 100F));

    }


	public void spawnItem() {
		if (rand < 15F) {
			
			Instantiate(FireUp, currentPosition, Quaternion.identity);
			Instantiate(FireUp2, currentPosition, Quaternion.identity);
			
			
		}
		else if (rand >= 15F && rand < 35F) {
			
			Instantiate(BombUp, currentPosition, Quaternion.identity);
			Instantiate(BombUp2, currentPosition, Quaternion.identity);
			
			
		}

		else if (rand >= 35F && rand < 45F) {
			
			Instantiate(MoveUp, currentPosition, Quaternion.identity);
			Instantiate(MoveUp2, currentPosition, Quaternion.identity);
			
			
		}
		else if (rand >= 45F && rand < 50F) {
			
			Instantiate(Pierce, currentPosition, Quaternion.identity);
			Instantiate(Pierce2, currentPosition, Quaternion.identity);
			
			
		}

	
	
	}

}
