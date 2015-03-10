using UnityEngine;
using System.Collections;

public class CannonEnemyMovement : MonoBehaviour {

	
	Rigidbody2D PlayerRB;
	private int direction;
	
	public float speed;//the speed at which the character moves

	private float timeState;//the timestate is when the 
	public float fireTime;//fire time is when the gun fires
	public float movementTime;//the amount in which the character moves
	public float pauseTIme;//the pause between fireing and moving
		// Use this for initialization
	void Start () {
		fireTime = 150;
		timeState = 0;
		speed = 1;
		movementTime = 100;
		PlayerRB = this.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate(){
		Vector2 moveDirect = new Vector2(0,0);
		if (timeState < 1) {
			int direction = Random.Range (0, 4);
			if(direction == 0)
				moveDirect = new Vector2(0, 1);
			if(direction == 1)
				moveDirect = new Vector2(1, 0);
			if(direction == 2)
				moveDirect = new Vector2(0, -1);
			if(direction == 3)
				moveDirect = new Vector2(-1, 0);
			

		}

		timeState++;
		//this is the time in which the character moves
		if (timeState < movementTime) {
			PlayerRB.velocity = moveDirect * speed;

		}
		//this is the time in which the character pauses
		if (timeState < movementTime || timeState >  movementTime + pauseTIme ) {

		}
		//this is the time in which the character fire
		if (timeState == movementTime + pauseTIme + fireTime) {}
		if (timeState > movementTime + pauseTIme + fireTime + pauseTIme) {
			timeState = 0;
		}

		Debug.Log (moveDirect);
			
		
	}
	

	
	void Update () {
		
		
		
		
	}
}
