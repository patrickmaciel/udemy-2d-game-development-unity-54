﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float valueRemaining = 10;
    public float valueMaximum = 30;
    public float valueConsumptionRate = 1f;

    public Text timerText;

    public bool gameInProgress = true;
    
	// Update is called once per frame
	void Update () {
	    if (gameInProgress)
        {
            valueRemaining -= Time.deltaTime * valueConsumptionRate;
            timerText.text = "Tempo restante: " + Mathf.Round(valueRemaining).ToString();

            if (valueRemaining < 0)
            {
                gameInProgress = false;
                endGameWithFailure();
            }
            // TODO
        }
	}

    void endGameWithFailure()
    {
        PersistentManager.dataStore.endGameWithLoss();
    }
}
