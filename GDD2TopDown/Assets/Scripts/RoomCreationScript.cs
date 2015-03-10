using UnityEngine;
using System.Collections;

public class RoomCreationScript : MonoBehaviour {
	//script is used for instantiating enemies in a room
	//it also does the checks to see how many enemies are left 
	// Use this for initialization
	public GameObject Slime;
	public int numSlime;
	void Start () {
		numSlime = 10;
		for (int i = 0; i < numSlime; i++) {
			Instantiate(Slime, new Vector3(Random.Range(-3,2), Random.Range(3, -2), 0), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
