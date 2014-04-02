using UnityEngine;

public class MouseControlledCamera : MonoBehaviour {

	public Vector3 Multipler = new Vector3(1,1,1);
	public float MinimumAltitude = 1;

	// Use this for initialization
	void Start ()
	{
		if (MinimumAltitude <= 0)
			Debug.LogError("Minimum Distance must be greater than zero.");
	}

	// Update is called once per frame
	void Update ()
	{

		var v = InputUtility.Direction.GetVector(Multipler).SwapYZ();

		// If the middle button is not being held down then clear x and y.
		if(!Input.GetMouseButton(2))
		{
			v.x = 0;
			v.z = 0;
		}
		else
		{
			v.x *= -1;
			v.z *= -1;
		}

		//v.y *= Mathf.Abs (transform.position.y);

		if (v.magnitude != 0)
		{
			var pos = transform.position + v;

			if (pos.y < MinimumAltitude)
				pos.y = MinimumAltitude;

			transform.position = pos;
		}
	}
}
