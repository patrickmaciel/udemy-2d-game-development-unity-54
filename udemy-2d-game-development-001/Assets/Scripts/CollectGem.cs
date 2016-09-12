using UnityEngine;
using System.Collections;

public class CollectGem : MonoBehaviour {

    public AudioClip soundEffect;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D target)
    {
        PersistentManager.dataStore.gemsCollected += 1;
        // Tag of the GameObject
        if (target.gameObject.tag == "Player")
        {
            if (soundEffect)
            {
                AudioSource.PlayClipAtPoint(soundEffect, transform.position);
            }
            Destroy(gameObject);
        }
    }
}
