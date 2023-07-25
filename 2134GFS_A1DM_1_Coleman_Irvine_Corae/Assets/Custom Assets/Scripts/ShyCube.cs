using UnityEngine;
using System.Collections;

public class ShyCube : MonoBehaviour 
{
	public Transform player;

	public Transform location;

	public Transform cube, cube2, cube3, cube4, cube5;

	public float max;

	// Use this for initialization
	void Start () 
	{
		if (player == null)
			GameObject.Find("FPSController");
		max = GetComponent<SphereCollider>().radius;
	}

	void OnTriggerStay()
	{
		if (player)
		{
			float d = Vector3.Distance(player.position, location.position);
			print("Distance to player: " + d);
			float scale = d / max;
			print(scale);
			cube.localScale = new Vector3(scale, scale, scale);
			cube2.localScale = new Vector3(scale, scale, scale);
			cube3.localScale = new Vector3(scale, scale, scale);
			cube4.localScale = new Vector3(scale, scale, scale);
			cube5.localScale = new Vector3(scale, scale, scale);
		}
	}
}
