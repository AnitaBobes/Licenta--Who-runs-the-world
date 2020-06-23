using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float turnSpeed = 100;
	public float speed = 5;

	void Update()
	{
		float x = Input.GetAxis("Horizontal");
		//up down with w and s
		float y = Input.GetAxis("Vertical");

		transform.Rotate(Vector3.up * x * turnSpeed * Time.deltaTime);
		transform.Translate(Vector3.forward * y * speed * Time.deltaTime);
		
	}
}
