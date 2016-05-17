using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {
	public GameObject explosionPart;
	public GameObject explosionPart2;
	private Vector3 currentPosition;
	private int i;
	private string test_tag;
	private GameObject obj;
	public GameObject explosionBomb;
	public int explosionlvl;



	void Awake () {
		currentPosition = transform.position + new Vector3(0f,-0.5f,0f);

		explosionlvl = Player1.explosionLevel;
	}

	void Start () {

		Instantiate(explosionPart, (currentPosition + new Vector3(0, 0.5f, 0)), Quaternion.identity);
		Instantiate(explosionPart2, (currentPosition + new Vector3(i, 0.5f, 0)), Quaternion.identity);

		for(i = 1; i < explosionlvl; i++)
		{
			foreach(var col in Physics.OverlapSphere ((currentPosition + new Vector3(i, 0.5f, 0)), 0.1f)){
				test_tag = col.gameObject.tag;
				obj = col.gameObject;
				break;
				
			}
			if(test_tag == "Wall" || test_tag == "ExplosionP"){
				
				break;
			}
			else if (test_tag == "Box"){
				//Instantiate(explosionPart, (currentPosition + new Vector3(i, 0.5f, 0)), Quaternion.identity);
				//Instantiate(explosionPart2, (currentPosition + new Vector3(i, 0.5f, 0)), Quaternion.identity);
				obj.GetComponent<BoxScript>().spawnItem();
				Destroy (obj);
				break;
			}
			else if (test_tag == "Player1" || test_tag == "Player2"){
				Instantiate(explosionPart, (currentPosition + new Vector3(i, 0.5f, 0)), Quaternion.identity);
				Instantiate(explosionPart2, (currentPosition + new Vector3(i, 0.5f, 0)), Quaternion.identity);
				Destroy (obj);
				
				
			}
			else if (test_tag == "Bomb"){
				Instantiate(explosionBomb, (currentPosition + new Vector3(i, 0.5f, 0)), Quaternion.identity);
				Destroy (obj);
				break;
					
				
			}
			else if (test_tag == "PowerUp"){
				Instantiate(explosionPart, (currentPosition + new Vector3(i, 0.5f, 0)), Quaternion.identity);
				Instantiate(explosionPart2, (currentPosition + new Vector3(i, 0.5f, 0)), Quaternion.identity);
				Destroy (obj);
				
				
			}
			else{
				Instantiate(explosionPart, (currentPosition + new Vector3(i, 0.5f, 0)), Quaternion.identity);
				Instantiate(explosionPart2, (currentPosition + new Vector3(i, 0.5f, 0)), Quaternion.identity);
			}
			
		}
		test_tag = "";
		
		for(i = 1; i < explosionlvl; i++)
		{
			foreach(var col in Physics.OverlapSphere ((currentPosition + new Vector3(0, 0.5f, i)), 0.1f)){
				test_tag = col.gameObject.tag;
				obj = col.gameObject;
				break;
				
			}
			if(test_tag == "Wall" || test_tag == "ExplosionP"){
				
				break;
			}
		else if (test_tag == "Box"){
				//Instantiate(explosionPart, (currentPosition + new Vector3(0, 0.5f, i)), Quaternion.identity);
				//Instantiate(explosionPart2, (currentPosition + new Vector3(0, 0.5f, i)), Quaternion.identity);
				obj.GetComponent<BoxScript>().spawnItem();
				Destroy (obj);
				break;
				
				
			}
			else if (test_tag == "Bomb"){
				Instantiate(explosionBomb, (currentPosition + new Vector3(0, 0.5f, i)), Quaternion.identity);
				Destroy (obj);
				break;
				
				
			}
			else if (test_tag == "PowerUp"){
				Instantiate(explosionPart, (currentPosition + new Vector3(0, 0.5f, i)), Quaternion.identity);
				Instantiate(explosionPart2, (currentPosition + new Vector3(0, 0.5f, i)), Quaternion.identity);
				Destroy (obj);
				
				
			}
			else if (test_tag == "Player1" || test_tag == "Player2"){
				Instantiate(explosionPart, (currentPosition + new Vector3(0, 0.5f, i)), Quaternion.identity);
				Instantiate(explosionPart2, (currentPosition + new Vector3(0, 0.5f, i)), Quaternion.identity);
				Destroy (obj);
				
				
			}

		else{
				Instantiate(explosionPart, (currentPosition + new Vector3(0, 0.5f, i)), Quaternion.identity);
				Instantiate(explosionPart2, (currentPosition + new Vector3(0, 0.5f, i)), Quaternion.identity);
			}
			
		}
		test_tag = "";

		for(i = 1; i < explosionlvl; i++)
		{
			foreach(var col in Physics.OverlapSphere ((currentPosition + new Vector3(-i, 0.5f, 0)), 0.1f)){
				test_tag = col.gameObject.tag;
				obj = col.gameObject;
				break;
				
			}
			if(test_tag == "Wall" || test_tag == "ExplosionP"){
				
				break;
			}
			else if (test_tag == "Box"){
				//Instantiate(explosionPart, (currentPosition + new Vector3(-i, 0.5f, 0)), Quaternion.identity);
				//Instantiate(explosionPart2, (currentPosition + new Vector3(-i, 0.5f, 0)), Quaternion.identity);
				obj.GetComponent<BoxScript>().spawnItem();
				Destroy (obj);
				break;


			}
			else if (test_tag == "Bomb"){
				Instantiate(explosionBomb, (currentPosition + new Vector3(-i, 0.5f, 0)), Quaternion.identity);
				Destroy (obj);
				break;
				
				
			}
			else if (test_tag == "PowerUp"){
				Instantiate(explosionPart, (currentPosition + new Vector3(-i, 0.5f, 0)), Quaternion.identity);
				Instantiate(explosionPart2, (currentPosition + new Vector3(-i, 0.5f, 0)), Quaternion.identity);
				Destroy (obj);
				
				
			}
			else if (test_tag == "Player1" || test_tag == "Player2"){
				Instantiate(explosionPart, (currentPosition + new Vector3(-i, 0.5f, 0)), Quaternion.identity);
				Instantiate(explosionPart2, (currentPosition + new Vector3(-i, 0.5f, 0)), Quaternion.identity);
				Destroy (obj);
				
				
			}
			else{
				Instantiate(explosionPart, (currentPosition + new Vector3(-i, 0.5f, 0)), Quaternion.identity);
				Instantiate(explosionPart2, (currentPosition + new Vector3(-i, 0.5f, 0)), Quaternion.identity);

			}

		}
		test_tag = "";

		for(i = 1; i < explosionlvl; i++)
		{
			foreach(var col in Physics.OverlapSphere ((currentPosition + new Vector3(0, 0.5f, -i)), 0.1f)){
				test_tag = col.gameObject.tag;
				obj = col.gameObject;
				break;
				
			}
			if(test_tag == "Wall" || test_tag == "ExplosionP"){
				
				break;
			}
			else if (test_tag == "Box"){
				//Instantiate(explosionPart, (currentPosition + new Vector3(0, 0.5f, -i)), Quaternion.identity);
				//Instantiate(explosionPart2, (currentPosition + new Vector3(0, 0.5f, -i)), Quaternion.identity);
				obj.GetComponent<BoxScript>().spawnItem();
				Destroy (obj);
				break;

				
		}
		else if (test_tag == "Bomb"){
			Instantiate(explosionBomb, (currentPosition + new Vector3(0, 0.5f, -i)), Quaternion.identity);
				Destroy (obj);
				break;
			
			
		}
		else if (test_tag == "PowerUp"){
			Instantiate(explosionPart, (currentPosition + new Vector3(0, 0.5f, -i)), Quaternion.identity);
			Instantiate(explosionPart2, (currentPosition + new Vector3(0, 0.5f, -i)), Quaternion.identity);
			Destroy (obj);
			
			
		}
			else if (test_tag == "Player1" || test_tag == "Player2"){
				Instantiate(explosionPart, (currentPosition + new Vector3(0, 0.5f, -i)), Quaternion.identity);
				Instantiate(explosionPart2, (currentPosition + new Vector3(0, 0.5f, -i)), Quaternion.identity);
				Destroy (obj);
				
				
			}
			else{
				Instantiate(explosionPart, (currentPosition + new Vector3(0, 0.5f, -i)), Quaternion.identity);
				Instantiate(explosionPart2, (currentPosition + new Vector3(0, 0.5f, -i)), Quaternion.identity);
			}
			
		}
		test_tag = "";


		Destroy (this.gameObject);
	
	}

		


	


}
