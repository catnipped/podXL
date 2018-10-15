using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour {
	public GameObject pod;
	Vector3 positionOffset;
	// Use this for initialization
	void Start () {
		positionOffset = transform.position;
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (pod.transform.position + positionOffset);
	}
}