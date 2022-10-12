using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightManager : MonoBehaviour
{
      private GameObject flashlight;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update() 
    {
        //        HingeJoint hinge = GetComponentInChildren(typeof(HingeJoint)) as HingeJoint;
        if (Input.GetButtonDown("Flashlight")) 
        {
            //GameObject light = this.transform.GetComponent("Light").gameObject;
            Light light = GetComponentInChildren(typeof(Light)) as Light;
            light.enabled = !light.enabled;
      

        }
        
    }  

} 
