using UnityEngine;

namespace RIA
{
    public class AirPlayerController2d : MonoBehaviour
    {
        [Header("移動遠度")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 3.5f;
        [SerializeField, Range(0, 10)]
        private float speedHorizontal = 4f;
        [Header("圖片")]
        [SerializeField] private Sprite pictureUp;
        [SerializeField] private Sprite pictureMiddle;
        [SerializeField] private Sprite pictureDown;

        [SerializeField, Header("圖片染元件")]

        private SpriteRenderer spr;

        private void Update()
        {
            // 上下 WS - Vertical
            // 左右 AD - Horizontal
            // 上 W +1
            // 下 S -1
            // 沒按 0
            // 輸入。取得抽向值（抽向名稱）-取得玩家按下按下鍵的值

            float v = Input.GetAxis("Vertical");

            //print("<color=red>玩家上下按鍵 : " + v + "</color>");

            // 左右 AD - Horizontal

            float h = Input.GetAxis("Horizontal");

            transform.Translate(
                speedHorizontal * Time.deltaTime * h,
                speedVertical * Time.deltaTime * v,
                0);

            // 如果 v 大於 0 就 住上
            if (v > 0)
            {
                //print("住上");
                spr.sprite = pictureUp;
            }
            // 如果 v 小於 0 就 往下
            if (v < 0)
            {
                //print("往下");
                spr.sprite = pictureDown;
            }
            // 如果 v 等於 就 中間
            if (v == 0)
            {
                //print("中間");
                spr.sprite = pictureMiddle;




            }
        }
    }
}
