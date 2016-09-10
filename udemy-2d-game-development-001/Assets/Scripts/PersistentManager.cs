using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;

public class PersistentManager : MonoBehaviour {

    public static PersistentManager dataStore;

    // Instance variable
    public int currentLevelID;

    // Persistent Variables
    public int gemsCollected;
    public int highestLevelCompleted;

    void Awake()
    {
        if (dataStore == null)
        {
            DontDestroyOnLoad(gameObject);
            dataStore = this;
        } else if (dataStore != this)
        {
            Destroy(gameObject);
        }
    }

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
