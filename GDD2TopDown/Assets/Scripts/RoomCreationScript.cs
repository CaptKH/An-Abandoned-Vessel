using UnityEngine;
using System.Collections;

public class RoomCreationScript : MonoBehaviour {
	//script is used for instantiating enemies in a room
	//it also does the checks to see how many enemies are left 
	// Use this for initialization
	public GameObject Slime;
	public GameObject TELEPORTER;
	public int numSlime;

	void Start () {
		numSlime = 10;

		instantiateEnemy (Slime, numSlime);

		getTeleporters ();




	}
	
	// Update is called once per frame
	void Update () {
	
	}


	//instantiates enemies using the type of enemy and the number of them
	void instantiateEnemy(GameObject EnemyType, int numEnemy){
		for (int i = 0; i < numEnemy; i++) {
			Instantiate(EnemyType, new Vector3(Random.Range(-3,2), Random.Range(3, -2), -0.3f), Quaternion.identity);
		}
	}
	//gets all the powered down teleporters and places a working tleporters
	void getTeleporters(){
		GameObject[] Teleporters;
		Teleporters = GameObject.FindGameObjectsWithTag("Teleporter");
		int rndTele = Random.Range (0, Teleporters.Length);

		Instantiate(TELEPORTER, new Vector3(Teleporters[rndTele].transform.position.x, Teleporters[rndTele].transform.position.y, -0.4f),Quaternion.identity);
		GameObject.Destroy (Teleporters [rndTele]);
	}
}
