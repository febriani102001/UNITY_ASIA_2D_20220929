using UnityEngine;

namespace RIA
{
    public class PlayerFinal : MonoBehaviour
    {
        private void OnDestroy()
        {
            //死亡
            FinalManager.instance.GameOver("  挑戰失敗！");

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            //過關
            FinalManager.instance.GameOver("  游戲通過");
        }
    }

   

}

