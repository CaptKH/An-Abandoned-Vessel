using UnityEngine;
using System.Collections;

public class ExitScript : MonoBehaviour {

	// Use this for initialization
	private string[] Rooms = new string[3] ;
	private GameObject MainGO;
	void Start () {
		Rooms[0] = "WarehouseA";
		Rooms[1] = "WarehouseB";
		MainGO = GameObject.FindGameObjectWithTag ("MainObject");

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//when the player hits the Exit
	void OnTriggerEnter2D(Collider2D other) {
		int LevelNum = Random.Range (0, 2);//randomly generate level number

		if (other.tag == "Player") {

			while(true)
			{
				//enter loop
				LevelNum = Random.Range (0, 3);

				if(Rooms[LevelNum] != Application.loadedLevelName)
				{

					Debug.Log("asd");
					Application.LoadLevel(Rooms[LevelNum]);
					DontDestroyOnLoad(MainGO);
					MainGO.GetComponent<MainScript>().difficultyLevel++;
					MainGO.GetComponent<MainScript>().roomNumber++;
	
					break;
				}
				else
				{
					continue;
				}
			}

		}

	}

}
