using UnityEngine;
using System.Collections;

public class ShyCube : MonoBehaviour 
{
	public Transform player;

	public Transform location;

	public Transform cube, cube2, cube3, cube4, cube5, cube6, cube7, cube8, cube9, cube10, cube11, cube12, cube13, cube14, cube15, cube16, cube17, cube18, cube19, cube20, cube21, cube22, cube23, cube24, cube25, cube26, cube27;

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
			cube6.localScale = new Vector3(scale, scale, scale);
			cube7.localScale = new Vector3(scale, scale, scale);
			cube8.localScale = new Vector3(scale, scale, scale);
			cube9.localScale = new Vector3(scale, scale, scale);
			cube10.localScale = new Vector3(scale, scale, scale);
			cube11.localScale = new Vector3(scale, scale, scale);
			cube12.localScale = new Vector3(scale, scale, scale);
			cube13.localScale = new Vector3(scale, scale, scale);
			cube14.localScale = new Vector3(scale, scale, scale);
			cube15.localScale = new Vector3(scale, scale, scale);
			cube16.localScale = new Vector3(scale, scale, scale);
			cube17.localScale = new Vector3(scale, scale, scale);
			cube18.localScale = new Vector3(scale, scale, scale);
			cube19.localScale = new Vector3(scale, scale, scale);
			cube20.localScale = new Vector3(scale, scale, scale);
			cube21.localScale = new Vector3(scale, scale, scale);
			cube22.localScale = new Vector3(scale, scale, scale);
			cube23.localScale = new Vector3(scale, scale, scale);
			cube24.localScale = new Vector3(scale, scale, scale);
			cube25.localScale = new Vector3(scale, scale, scale);
			cube26.localScale = new Vector3(scale, scale, scale);
			cube27.localScale = new Vector3(scale, scale, scale);
		}
	}
}
