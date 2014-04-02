using UnityEngine;
using System.Collections;

public class BarrelAngle : MonoBehaviour {
	
	protected float _angle = 0f;

	public float AngleMultiple = 0.1f;
	public float MaximumStep = 0.1f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		var delta = -Mathf.Clamp (Input.GetAxis ("Mouse Y") * AngleMultiple, -MaximumStep, MaximumStep);
		_angle += delta;
		_angle = Mathf.Clamp (_angle, -0.5f, 0);
		transform.localRotation = new Quaternion(_angle, 0, 0, 1);
	}
}
