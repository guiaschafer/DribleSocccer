using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paginainicial : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Submit"))
        {
            Application.LoadLevel("Fase1");
        }
    }
}
