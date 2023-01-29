using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace lgames
{
    public class UIMenuHandler : MonoBehaviour
    {

        #region :: Variables
        public GameSceneManager _gameSceneManager;
        #endregion

        #region :: Listeners

        #endregion

        #region :: Lifecycle
        #endregion

        #region :: Properties

        #endregion

        #region :: Events

        #endregion

        #region :: Actions
        public void SoloAction()
        {
            _gameSceneManager.SwitchSceneTo(GameScene.InGame);
            Log.Info(this, "Loading solo game");
        }

        public void MultiplierAction()
        {
            _gameSceneManager.SwitchSceneTo(GameScene.InGame);
            Log.Info(this, "Loading multiplier game");
        }

        public void QuitAction()
        {
            Application.Quit(0);
            Log.Warn(this, "Player exit the game");
        }
        #endregion

        #region :: Methods

        #endregion

        #region :: Enumerator 

        #endregion

    }
}
