using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class DoorButtonHandler : MonoBehaviour
{
    private bool doorOpen;
    public GameObject doorHeld;
    public GameObject player;
	public LayerMask clickableLayer;

    // Start is called before the first frame update
    public void Start()
    {
        doorOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 50, clickableLayer.value))
            {
                if(hit.collider.gameObject.tag == "Button")
                {   
        SceneManager.LoadScene("Assets/Scenes/entry2-medical-bay.unity");

                }
            }
        }
    }
    
}
