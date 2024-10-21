using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace MyFPS
{
    public class PauseUI : MonoBehaviour
    {
        public string playScene = "PlayScene";
        public string menuScene = "MainMenu";

        private void Start()
        {

        }

        private void OnEnable()
        {
            
        }

        public void Retry()
        {
            SceneFade.instance.FadeOut(playScene);
            // �Ͻ����� ����
            Time.timeScale = 1.0f;

        }
        public void Menu()
        {
            //SceneFade.instance.FadeOut(menuScene);
            //Time.timeScale = 1.0f;
        }
        public void Continue()
        {
            UIManager.Instance.ResetPause();
        }


    }
}
