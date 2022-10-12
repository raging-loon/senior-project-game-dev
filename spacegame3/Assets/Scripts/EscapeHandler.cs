using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeHandler : MonoBehaviour
{
    private bool menuShowing = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetButtonDown("Cancel"))
        // {
        //   if(menuShowing == false)
        //   {
        //     menuShowing = true;
        //     SceneManager.LoadSceneAsync("Assets/Scenes/PauseMenu.unity");
            
        //   } else {
        //     menuShowing = false;
        //     SceneManager.UnloadSceneAsync("Assets/Scenes/PauseMenu.unity");
        //   }
        // }
    }
}
