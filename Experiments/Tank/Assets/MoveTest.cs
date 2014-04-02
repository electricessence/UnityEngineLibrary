using UnityEngine;
using System.Collections;

public class MoveTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 0.1f, 0);

		transform.Translate(0.01f,0,0);
	}
}
