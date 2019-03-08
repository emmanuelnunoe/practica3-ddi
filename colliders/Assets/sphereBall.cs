using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBall : Interactable 
{
	public float kickForce = 30f;
	public Vector3 kickDirection;
	Rigidbody rb;

	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	protected override void Awake()
	{
		base.Awake();
		rb = GetComponent<Rigidbody>();
	}
	public override void Interact()
	{
		Debug.Log("SphereBall");
		rb.AddForce(kickDirection * kickForce, ForceMode.Force);
	}
}
