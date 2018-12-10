using UnityEditor;
using UnityEngine;
using UnityEngine.Advertisements;

namespace Assets.Script
{
    public class Ad : MonoBehaviour {

        public void ShowAd()
        {
            if (Advertisement.IsReady())
            {
                Advertisement.Show();
                //while (Advertisement.isShowing)
                //{
                //    PauseGame();
                //}
                //ContinueGame();
            }
        }

        private void PauseGame()
        {
            Time.timeScale = 0;
            //Disable scripts that still work while timescale is set to 0
        }
        private void ContinueGame()
        {
            Time.timeScale = 1;
            //enable the scripts again
        }
    }

   
}
