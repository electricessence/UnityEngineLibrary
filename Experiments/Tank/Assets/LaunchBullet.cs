using UnityEngine;
using System.Collections;

public class LaunchBullet : MonoBehaviour {

	public float ForceMultiplier = 2000f;
	public Rigidbody Bullet;
	public Transform ShootPosition;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump") || Input.GetMouseButtonUp(0))
		{
			var rot = ShootPosition.rotation;
			var newBullet = Instantiate(Bullet, transform.position, rot) as Rigidbody;
			newBullet.useGravity = true;
		
			newBullet.rigidbody.AddForce(ShootPosition.forward * ForceMultiplier);
		}
	}
}
