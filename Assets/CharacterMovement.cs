﻿using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {
	public float speed;
	public float rotateSpeed;
	CharacterController controller;
	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		float vert = Input.GetAxis("Vertical");
		float hori = Input.GetAxis("Horizontal");


		controller.Move(vert * Camera.main.transform.forward * Time.deltaTime * speed 
															+ Physics.gravity);
		transform.Rotate(0f, hori * Time.deltaTime * rotateSpeed, 0f);
	}
}