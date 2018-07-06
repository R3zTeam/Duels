using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rollingbush : MonoBehaviour {
    public float ballSpeed;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        var Horizontal = Input.GetAxis("Horizontal");
        var Vertical = Input.GetAxis("Vertical");

        Rigidbody body = GetComponent<Rigidbody>();
        body.AddTorque(new Vector3(Horizontal, 0, Vertical));
	}
}
