using UnityEngine;
using System.Collections;

public class PlayerKnockback : MonoBehaviour {

	private Vector2 negDirection;
	private float force;
	private Rigidbody2D PlayerRB;
	private bool isHit;
	// Use this for initialization
	void Start () {

		PlayerRB = this.GetComponent<Rigidbody2D>();

		force = 10f;
	}
	
	// Update is called once per frame
	void Update () {
		//isHit = this.GetComponent<PlayerMovement> ().isHit;
		negDirection = this.GetComponent<PlayerMovement>().direction;
		negDirection.x = negDirection.x * -1;
		negDirection.y = negDirection.y * -1;

		if (PlayerRB.velocity.x < 0.1f && PlayerRB.velocity.x > -0.1f) {
			this.GetComponent<PlayerMovement> ().isHit = false;
		}

		if (PlayerRB.velocity.y < 0.1f && PlayerRB.velocity.y > -0.1f) {
			this.GetComponent<PlayerMovement> ().isHit = false;
		}

	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Enemy") {
			//Debug.Log("Hit Enemy");

			PlayerRB.velocity = negDirection * force;
			this.GetComponent<PlayerMovement> ().isHit = true;

		}
	}
}
