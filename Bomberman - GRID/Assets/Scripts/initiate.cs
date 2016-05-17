using UnityEngine;
using System.Collections;

public class initiate : MonoBehaviour {

	private int bottomZ = 3, bottomX = 3, gridWidth = 1;
	public GameObject wall;
	public GameObject box;

	void Start () {
	
		int counterZ = 0;
		string line;

		System.IO.StreamReader file = new System.IO.StreamReader("assets/inputs/level01.txt");
		while((line = file.ReadLine()) != null) {

			for (int counterX = 0; counterX <= 16; counterX++){

				int posX = bottomX + counterX * gridWidth;
				int posZ = bottomZ + counterZ * gridWidth;
				if (line[counterX] == '1') {

					Instantiate(wall, new Vector3(posX, 0.5f, posZ), Quaternion.identity);
				}
				else if (line[counterX] == '2') {
					
					Instantiate(box, new Vector3(posX, 0.5f, posZ), Quaternion.identity);
				}
			}
			counterZ++;
		}
		
		file.Close();
	}

	void Update () {
	
	}
}
