using UnityEngine;
using System.Collections;

public class MouseMoveAnt : MonoBehaviour {

	public float MovementMultiplier = 5.0f;
	public float TurnMultiplier = 5.0f;

	protected CharacterController _charController;

	// Use this for initialization
	void Start () {
		//_charController = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		var v = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis ("Vertical"));

		transform.Rotate (0, v.x * this.TurnMultiplier, 0);
		transform.Translate (0, 0, v.y * MovementMultiplier);
		//_charController.SimpleMove(transform.rotation * new Vector3 (0, 0, MovementMultiplier * v.y));
	}
}
