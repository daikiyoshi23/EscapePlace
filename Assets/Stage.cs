using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour {

    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("up")) {
            transform.Rotate(1f*Time.deltaTime*speed, 0f, 0f);
        }
        if (Input.GetKey("down")) {
            transform.Rotate(-1f * Time.deltaTime*speed, 0f, 0f);
        }
        if (Input.GetKey("right")) {
            transform.Rotate(0f, 0f, -1f*Time.deltaTime * speed);
        }
        if (Input.GetKey("left")) {
            transform.Rotate(0f, 0f, 1f * Time.deltaTime * speed);
        }
    }
}
