using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {
	
	static public float moveSpeed;
	public float turnSpeed = 15.0f;
	static public int explosionLevel;
	static public int bombLevel;
	static public int bombCount;
	static public bool pierceState;
	public GameObject bomb;
	public GameObject pierceBomb;
	
	void Start () {
		explosionLevel = 2;
		bombLevel = 1;
		bombCount = 0;
		moveSpeed = 5.0f;
		pierceState = false;
	}
	
	void Update () {
		
		if (Input.GetKey ("up")) {
			GetComponent<Rigidbody>().MovePosition (transform.position + Vector3.forward * moveSpeed * Time.deltaTime);
			//transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);	
		} else if (Input.GetKey ("down")) {
			GetComponent<Rigidbody>().MovePosition (transform.position - Vector3.forward * moveSpeed * Time.deltaTime);
			//transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
		} else if (Input.GetKey ("right")) {
			GetComponent<Rigidbody>().MovePosition (transform.position + Vector3.right * moveSpeed * Time.deltaTime);
			//transform.position += transform.right * moveSpeed * Time.deltaTime;
		} else if (Input.GetKey ("left")) {
			GetComponent<Rigidbody>().MovePosition (transform.position - Vector3.right * moveSpeed * Time.deltaTime);
			//transform.position -= transform.right * moveSpeed * Time.deltaTime;
		}	
		
		
		if (Input.GetKeyDown ("[0]") && bombCount < bombLevel) {
			
			Vector3 positionBomb = new Vector3 (Mathf.Round (transform.position.x), 1, Mathf.Round (transform.position.z));
			if (pierceState == false){
				Instantiate (bomb, positionBomb, Quaternion.identity); 
			}
			else {
				Instantiate (pierceBomb, positionBomb, Quaternion.identity); 
			}
			bombCount++;
		}
		
		
		
		
	}
	
}
