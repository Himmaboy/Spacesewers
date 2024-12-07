using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryScreen : MonoBehaviour {

   public void RetryGame ()
   {
       SceneManager.LoadScene(2);
   }
        
   public void MainMenu ()
   {
       SceneManager.LoadScene(0);
   }
    
}
