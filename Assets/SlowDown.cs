using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : MonoBehaviour
{
	public Rigidbody rb;

	void OnTriggerEnter()
	{
		rb.drag = 0.1f;
	}
	void OnTriggerExit()
	{
		rb.drag = 1;
		Debug.Log("Exit");
	}
}
