using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

namespace RIA
{

    public class FinalManager : MonoBehaviour
    {
        public static FinalManager instance;

        private CanvasGroup groupFinal;

        private TextMeshProUGUI textTitle;

        private Button btnReplay;

        private void Awake()
        {

            instance = this;
            groupFinal = GameObject.Find("結束畫布").GetComponent<CanvasGroup>();
            textTitle = GameObject.Find("結束標題").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("重新游戲").GetComponent<Button>();
            btnReplay.onClick.AddListener(Replay);

        }

        /// <summary>
        /// 游戲 結束
        /// </summary>
        /// <param name="title">游戲標題</param>
        public void GameOver(string title)
        {
            textTitle.text = title;
            StartCoroutine(FadeIn());
        }

        private IEnumerator FadeIn()

        {
            for (int i = 0; i < 10; i++)
            {

                groupFinal.alpha += 0.1f;
                yield return new WaitForSeconds(0.02f);
            }

            groupFinal.interactable = true;
            groupFinal.blocksRaycasts = true;
           
        }

        /// <summary>
        /// 重新游戲
        /// </summary>
        private void Replay()
        {
            SceneManager.LoadScene("BACKGROUND");
        }
    }
}
