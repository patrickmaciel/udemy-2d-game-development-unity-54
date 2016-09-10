using UnityEngine;
using System.Collections;

public class RandomSprite : MonoBehaviour {

    public Sprite[] sprites;

	// Use this for initialization
	void Start () {
        var myRenderer = GetComponent<SpriteRenderer>();
        if (sprites.Length > 0)
        {
            myRenderer.sprite = sprites[Random.Range(0, sprites.Length)];
            myRenderer.sortingOrder = Random.Range(-10, 10);
        }	
	}
}
