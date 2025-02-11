﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{

    public GameObject elevatorPanel;

    void Start()
    {
        elevatorPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            elevatorPanel.SetActive(true);   
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.tag == "Player") {
            elevatorPanel.SetActive(false);
        }
    }

}
