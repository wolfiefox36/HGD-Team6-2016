using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PreviousScreenScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Button>().onClick.AddListener(delegate
        {
            SceneManager.LoadScene("TitleMenu");
        });
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
