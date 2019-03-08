using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour 
{
	public Color newColor;
	public GameObject infoCanvas;
	Renderer rend;
	bool isInsideZone;

	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	protected virtual void Awake()
	{
		rend = GetComponent<Renderer>();
	}

	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
	{
		infoCanvas.SetActive(false);
	}

	/// <summary>
	/// Update is called every frame, if the MonoBehaviour is enabled.
	/// </summary>
	void Update()
	{
		if(isInsideZone)
		{
			if(Input.GetKeyDown(KeyCode.C))
			{
				Interact();
			}
		}
	}

	/// <summary>
	/// OnTriggerEnter is called when the Collider other enters the trigger.
	/// </summary>
	/// <param name="other">The other Collider involved in this collision.</param>
	void OnTriggerEnter(Collider other)
	{
		if(!other.CompareTag("Player"))
			return;
		// Debug.Log("Entraste en la esfera!");
		// rend.material.color = newColor;
		isInsideZone = true;
		infoCanvas.SetActive(true);
	}

	/// <summary>
	/// OnTriggerExit is called when the Collider other has stopped touching the trigger.
	/// </summary>
	/// <param name="other">The other Collider involved in this collision.</param>
	void OnTriggerExit(Collider other)
	{
		infoCanvas.SetActive(false);
		isInsideZone = false;
	}

	public virtual void Interact()
	{
		rend.material.color = newColor;
	}
}
