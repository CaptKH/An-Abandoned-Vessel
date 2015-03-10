using UnityEngine;
using System.Collections;
//this makes the camera lerp and follow the player with a little bit of drag
public class CameraFollow : MonoBehaviour {
	//class variables
	GameObject Player;
	Rigidbody2D PlayerRB;
	float lerpDistance;
	Vector2 MovementBuffer;//Movement buffer offsets the the camera from teh center when the player is moving
	// Use this for initialization
	void Start () {
		lerpDistance = 30.0f;//lerpdistance divides the velocity that will be applied to the camera.  This will
		MovementBuffer = new Vector2 (0,0);// this is the amount the camera will drag by. saved as a vector 2d
		Player = GameObject.FindWithTag ("Player");//gets the player object
		PlayerRB = Player.GetComponent<Rigidbody2D>();//gets the players rigidbody
	}
	
	// Update is called once per frame
	void Update () {
		//Mathf.Clamp (Input.mousePosition.x, Player.transform.position.x - 1, Player.transform.position.x + 1);
		//Mathf.Clamp (Input.mousePosition.y, Player.transform.position.y - 1, Player.transform.position.y + 1);
		//this.transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		//movement buffer is equal to the velocity of the player/ lerp distance
		/*
		if (PlayerRB.velocity.x > 0) {
			MovementBuffer.x = PlayerRB.velocity.x/ lerpDistance;
		}
		if (PlayerRB.velocity.x < 0) {
			MovementBuffer.x = PlayerRB.velocity.x/ lerpDistance;
		}
		if (PlayerRB.velocity.y > 0) {
			MovementBuffer.y = PlayerRB.velocity.y/ lerpDistance;
		}
		if (PlayerRB.velocity.y < 0) {
			MovementBuffer.y = PlayerRB.velocity.y/ lerpDistance;
		}
		*/
		//apply to the camera transform 
		//Mathf.Clamp (MovementBuffer.x, -2, 2);
		this.transform.position = new Vector3(Player.transform.position.x + MovementBuffer.x ,Player.transform.position.y + MovementBuffer.y, -10 );
	}
}
