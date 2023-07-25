using UnityEngine;
using System.Collections;

public class Glow : MonoBehaviour 
{
	public ParticleSystem particleSystem;

	void Start()
	{
		particleSystem.Stop();

	}

	void OnMouseEnter()
	{
		print("enter");
		ParticleSystem ps = GetComponent<ParticleSystem>();
		ps.Play();
	}
	

	void OnMouseOver()
	{
		print("over");
	}


	void OnMouseExit()
	{
		print("exit");
		
		ParticleSystem ps = GetComponent<ParticleSystem>();
		ps.Stop();
	}
}