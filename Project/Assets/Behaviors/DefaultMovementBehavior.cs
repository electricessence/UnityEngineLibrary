using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class DefaultMovementBehavior : MonoBehaviour {

	public InputUtility.Movement.Type XAxisMovement = InputUtility.Movement.Type.Turn;
	public Vector2 MovementMultiplier = new Vector2( 1.0f, 1.0f );

	protected CharacterController _controller;

	// Use this for initialization
	void Start () {
		_controller = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		var v = InputUtility.Movement.GetAxisVector(MovementMultiplier * Time.deltaTime);

		switch (XAxisMovement)
		{

			case InputUtility.Movement.Type.Turn:
				transform.Rotate (0, v.x * Mathf.Rad2Deg, 0);
				transform.Translate (0, 0, v.y);
				break;

			case InputUtility.Movement.Type.Slide:
				transform.Translate (v.x, 0, v.y);	
				break;

		}

		//_charController.SimpleMove(transform.rotation * new Vector3 (0, 0, MovementMultiplier * v.y));
	}
}
