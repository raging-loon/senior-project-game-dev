using UnityEngine;
using System.Collections;
using System;
public class AlarmMgr : MonoBehaviour
{

    public Light RedLight;
    public int Number = 1;
    public float maxInstensity = 0;
    private long msBase;
    
    // Use this for initialization
    void Start()
    {
        Number = 1;
        RedLight.GetComponent<Light>().intensity = 0;
        msBase = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        Debug.Log(msBase);
        if (maxInstensity == 0) maxInstensity = 21;
    }

    // Update is called once per frame
    void Update()
    {
       long time = DateTimeOffset.Now.ToUnixTimeMilliseconds(); 
        if (time > msBase + (Number == 1 ? 1000 : 1000))
        {
            if (Number == 1)
            {
                Number = 2;
                RedLight.GetComponent<Light>().intensity = maxInstensity;
                RedLight.GetComponent < MeshRenderer>().material.EnableKeyword("_EMISSION");
                RedLight.GetComponent<Light>().GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
            }
            else
            {
                Number = 1;
                RedLight.GetComponent<Light>().intensity = 0;
                //RedLight.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);

            }
            msBase = time;
        }
        

    }
    IEnumerator waitforred()
    {
        yield return new WaitForSeconds(1f);
        if (Number == 1) Number = 2; else Number = 1;
    }
  
}
 