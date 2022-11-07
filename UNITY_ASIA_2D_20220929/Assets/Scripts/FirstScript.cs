using UnityEngine;

namespace RIA
{
    /// <summary>
    /// 2022.10.03
    /// </summary>
    public class FirstScript : MonoBehaviour
    {
        #region
     
        private void Awake()
        {
            print("Hello World");
         }

      
        private void Start()
        {
            print("<color=yellow>");
        }
        // 更新事件 ：Start 之後執行， 執行約 60 FPS
        private void Update()
        {
            print("<color=yellow>更新事件</color>");
        }
        #endregion
    }
}
