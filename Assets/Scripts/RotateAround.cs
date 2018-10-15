using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public GameObject origo;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = origo.transform.position + Vector3.forward * 5;
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal"));

        Vector3 directionToOrigo = origo.transform.position - transform.position;
        transform.rotation = Quaternion.FromToRotation(Vector3.back, directionToOrigo);

    }
}
