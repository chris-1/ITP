using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour {

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

        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);



        if (moveHorizontal != 0 || moveVertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(movement);
        }

        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);

        /*
        if (Input.GetKeyDown ("space") && bombCount < bombLevel) {
			
			Vector3 positionBomb = new Vector3 (Mathf.Round (transform.position.x), 1, Mathf.Round (transform.position.z));
			if (pierceState == false){
				Instantiate (bomb, positionBomb, Quaternion.identity); 
			}
			else {
				Instantiate (pierceBomb, positionBomb, Quaternion.identity); 
			}
			bombCount++;
		}
        */
		
		
		
		
	}
	
}
