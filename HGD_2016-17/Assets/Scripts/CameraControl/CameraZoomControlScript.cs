using UnityEngine;
using System.Collections;

public class CameraZoomControlScript : MonoBehaviour {

	public float desiredZoomAmount;
	public float zoomSpeed;
	private Camera camera;

	// Use this for initialization
	void Start () {
		camera = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		camera.orthographicSize = Mathf.Lerp (camera.orthographicSize, desiredZoomAmount, Time.deltaTime * zoomSpeed);
	}
}
