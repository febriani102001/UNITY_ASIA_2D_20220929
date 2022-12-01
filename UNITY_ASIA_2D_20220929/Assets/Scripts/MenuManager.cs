using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace RIA
{

    public class MenuManager : MonoBehaviour
    {
        private Button btnPlay;


        private void Awake()
        {
            btnPlay = GameObject.Find("開始游戲").GetComponent<Button>();
            btnPlay.onClick.AddListener(StartGame);
        }

        private void StartGame()
        {
            SceneManager.LoadScene("游戲場景");
        }
    }
}
