﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderScens : MonoBehaviour
{
   public void LoadNextScene(string sceneName){
       SceneManager.LoadScene(sceneName);
   }
   public void exitGame(){
       Application.Quit();
   }

}