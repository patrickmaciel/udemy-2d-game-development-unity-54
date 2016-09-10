using UnityEngine;
using System.Collections;

public class CameraFollow2D : MonoBehaviour {

    public float boundsTop = 0.0f;
    public float boundsBottom = 0.0f;
    public float boundsLeft = 0.0f;
    public float boundsRight = 0.0f;

    private Transform target;

	// Use this for initialization
	void Start () {
        target = GameObject.FindWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(
                                Mathf.Clamp(target.position.x, boundsLeft, boundsRight),
                                Mathf.Clamp(target.position.y, boundsBottom, boundsTop),
                                transform.position.z
        );
	}
}
