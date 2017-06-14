using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
	private Rigidbody rb;
	public float speed;
	private int count;
	public Text countText, winText;
	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		count = 0;
		countText.text = "Count : " + count.ToString ();
		winText.text = "";
	}
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal, moveVertical;
		moveHorizontal = Input.GetAxis ("Horizontal");
		moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * speed);
	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Collect")) {
			other.gameObject.SetActive (false);
			count++;
			countText.text = "Count : " + count.ToString ();
		}
		if(count == 10)
			winText.text = "You win!";
	}
}
