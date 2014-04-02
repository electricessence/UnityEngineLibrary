using UnityEngine;
using System.Collections;

public class TurretAngle : MonoBehaviour {

	protected float _angle = 0f;
	
	public float AngleMultiple = 10f;
	public float MaximumStep = 10f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var clamped = Mathf.Clamp (Input.GetAxis ("Mouse X") * AngleMultiple, -MaximumStep, MaximumStep);
		transform.Rotate (0, clamped, 0);
	}
}
