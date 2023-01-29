using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace lgames
{

    // add at the bottom
    public enum GameScene
    { 
        Main,
        InGame
    }

    public class GameSceneManager : Singleton
    {

        public void SwitchSceneTo(GameScene gameScene) 
        {
            switch (gameScene)
            {
                case GameScene.Main:
                    SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
                    break;
                case GameScene.InGame:
                    SceneManager.LoadScene("InGameScene", LoadSceneMode.Single);
                    break;
            }
        }

    }
}
