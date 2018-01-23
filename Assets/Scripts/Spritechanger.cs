using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spritechanger : MonoBehaviour {

	public SpriteRenderer sr;
	public Transform tf;


	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer> ();
		tf = GetComponent<Transform> ();

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			sr.color = Color.blue;
		} else {
			sr.color = Color.white;
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			//move to the right 
			tf.position = tf.position + Vector3.right;
		}

			if (Input.GetKey(KeyCode.UpArrow)){
				//move up
				tf.position = tf.position + Vector3.up;
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {
				//move to the left
				tf.position = tf.position + Vector3.left;
			}
			if (Input.GetKey(KeyCode.DownArrow)){
				//move down
				tf.position = tf.position + Vector3.down;
			}

		}
	
	}

