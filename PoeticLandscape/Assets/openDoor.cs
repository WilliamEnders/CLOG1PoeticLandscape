using UnityEngine;
using System.Collections;

public class openDoor : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(){
		GameObject.Find ("door").GetComponent<MeshRenderer> ().enabled = false;
		GameObject.Find ("door").GetComponent<BoxCollider> ().enabled = false;
		GameObject.Find ("door").GetComponent<AudioSource> ().Play ();
	}
	void OnTriggerExit(){
		GameObject.Find ("door").GetComponent<MeshRenderer> ().enabled = true;
		GameObject.Find ("door").GetComponent<BoxCollider> ().enabled = true;
	}

}
