using UnityEngine;
using System.Collections;

public class CollectGem : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D target)
    {
        // Tag of the GameObject
        if (target.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
