using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharController : MonoBehaviour {

    private CharacterController m_CharacterController;
    private Camera m_Camera;

    // Use this for initialization
    void Start ()
    {
        m_CharacterController = GetComponent<CharacterController>();
        m_Camera = Camera.main;
    }
	
	// Update is called once per frame
	void Update ()
    {
	    
	}
}
