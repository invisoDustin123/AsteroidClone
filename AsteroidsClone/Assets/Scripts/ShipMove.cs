using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour {
	//declaring variables for speeds and the transform component
    public float rSpeed = 5f;
    public float mSpeed = 0.1f;
	private Transform tf;

	// Use this for initialization
	void Start () {
		//storing the transform component as a variable
        tf = GetComponent<Transform>();
    }
	

    // Update is called once per frame
    void Update()
    {
		//if the up arrow is pressed, move forward
		if (Input.GetKey (KeyCode.UpArrow)) {
			
			tf.Translate (mSpeed, 0, 0);
		}
		//if the right arrow is pressed, rotate to the right
		if (Input.GetKey (KeyCode.RightArrow)) {
			tf.Rotate (0, 0, -rSpeed);
		}
		//if the left arrow is pressed, rotate to the left
		if (Input.GetKey (KeyCode.LeftArrow)) {
			tf.Rotate (0, 0, rSpeed);
		}

    }

}
