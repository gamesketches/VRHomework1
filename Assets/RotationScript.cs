using UnityEngine;
using System.Collections;

public class RotationScript : MonoBehaviour {

	public GameObject directionalLight;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(directionalLight.transform.position, Vector3.up, 1);
	}
}
