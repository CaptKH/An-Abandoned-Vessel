using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	Rigidbody2D PlayerRB;
	public float speed;
	public Vector2 direction;
	public bool isHit;
	// Use this for initialization
	void Start () {
		direction = new Vector2 (0, 0);
		speed = 30.0f;
		isHit = false;
		PlayerRB = this.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate(){
		if (isHit == false) {
			if (Input.GetKey (KeyCode.A)) {
				direction = new Vector2 (-1, 0);
				PlayerRB.AddForce (new Vector2 (-1, 0) * speed);
			}
			if (Input.GetKey (KeyCode.D)) {
				direction = new Vector2 (1, 0);
				PlayerRB.AddForce (new Vector2 (1, 0) * speed);
			}
			if (Input.GetKey (KeyCode.W)) {
				direction = new Vector2 (0, 1);
				PlayerRB.AddForce (new Vector2 (0, 1) * speed);
			}
			if (Input.GetKey (KeyCode.S)) {
				direction = new Vector2 (0, -1);
				PlayerRB.AddForce (new Vector2 (0, -1) * speed);
			}
		}


	}
	void Update () {




	}
}
