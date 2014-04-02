using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class SimpleCharacterMovement : MonoBehaviour {

	public InputUtility.Movement.Type XAxisMovement = InputUtility.Movement.Type.Turn;
	public Vector2 MovementMultiplier = new Vector2( 1.0f, 1.0f ); // Z is vertical.

	protected CharacterController _controller;

	// Use this for initialization
	void Start ()
	{
		_controller = GetComponent<CharacterController> ();

		if(!_controller.enabled)
			Debug.LogWarning("Character Controller is disabled.");

		_controller.SimpleMove(new Vector3());
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(_controller.isGrounded)
		{

			var v = InputUtility.Movement.GetVector(MovementMultiplier);

			if(v.magnitude!=0) switch (XAxisMovement)
			{
				case InputUtility.Movement.Type.Turn:
					transform.Rotate (0, v.x * Mathf.Rad2Deg * Time.deltaTime, 0);
					_controller.SimpleMove( transform.rotation * v.Forward3() );
					break;

				case InputUtility.Movement.Type.Slide:
					_controller.SimpleMove( transform.rotation * v.SwapYZ() );
					break;

			}

		}
		else if(!_controller.isGrounded)
		{
			_controller.SimpleMove(new Vector3());
		}

	}
}
