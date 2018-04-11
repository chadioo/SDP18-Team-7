﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    public void changeToScene(int changeTheScene) {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        SceneManager.LoadScene(changeTheScene);
    }
}
