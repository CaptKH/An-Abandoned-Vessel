using UnityEngine;
using System.Collections;

public class SliderEnemyMovement : MonoBehaviour {

	Rigidbody2D PlayerRB;
	private int direction;

	public float speed;
	private float movementTime;
	private 
	// Use this for initialization
	void Start () {
		
		speed = 150;
		movementTime = 0.10f;
		PlayerRB = this.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate(){
		direction = Random.Range (0, 4);

		if ((PlayerRB.velocity.x < movementTime && PlayerRB.velocity.x > -movementTime) && 
		    (PlayerRB.velocity.y < movementTime && PlayerRB.velocity.y > -movementTime)) {

			switch(direction){
				case 0:
					PlayerRB.AddForce (new Vector2(0, 1) * speed);
					break;
				case 1:
					PlayerRB.AddForce (new Vector2(1, 0) * speed);
					break;
				case 2:
					PlayerRB.AddForce (new Vector2(0, -1) * speed);
					break;
				case 3:
					PlayerRB.AddForce (new Vector2(-1, 0) * speed);
					break;
				
				}
				
			}


		}


		
		

	void Update () {
		
		
		
		
	}
}
