using UnityEngine;
using System.Collections;

public class CameraZoomZoneScript : MonoBehaviour {

	public float cameraSize = 10f;
	private float defaultCameraSize;
	private Camera camera;
	private CameraZoomControlScript cameraControl;
	private GameObject player;

	// Use this for initialization
	void Start () {
		camera = GameObject.FindWithTag ("MainCamera").GetComponent<Camera> ();
		defaultCameraSize = camera.orthographicSize;
		cameraControl = camera.GetComponent<CameraZoomControlScript> ();
		player = GameObject.FindWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D obj) {
		if (obj.gameObject == player) {
			cameraControl.desiredZoomAmount = cameraSize;
		}
	}

	void OnTriggerExit2D(Collider2D obj) {
		if (obj.gameObject == player) {
			cameraControl.desiredZoomAmount = defaultCameraSize;
		}
	}
}
