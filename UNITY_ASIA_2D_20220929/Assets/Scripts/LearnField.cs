using UnityEngine;

namespace RIA
{ 
    /// <summary>
    /// 學習欄位 Field
    /// </summary>
    public class LearnField : MonoBehaviour
    {
        // Field：除存資料
        // 語法：
        // 資料類型 欄位名稱；

        // 定義了一筆資料，名稱 level 類型是整數
        private int level;

        // = 指定符號： 將右邊的結果給給左邊
        // = 修飾詞：設定資料權限
        // = 私人僅允許此類別存取
        private int enemy = 7;
        // = 公開 ： 允許所有類別存取

        public int hp = 100;
        public int countProp = 7;

        public float speed = 3.5f;
        public float jump = 7.7F;

        public string namePlayer = "yo";
        public string content = "Hai";

        public bool isPass = true;
        public bool isDead = false;

        [Header("武器數量")]
        public int weaponCount = 10;
        [Tooltip("這是補充 100 滴 HP 的紅色藥水， 一罐 999 元。")]
        public string propName = "紅色藥水";

        [Range(0, 100)]
        public int score = 60;
        [Range(1f, 10.5f)]
        public float walkSpeed = 3.7f;
        [Range(1, 7)]
        public string nameWeapon = "打火機";

        [SerializeField]
        private string password = "1@3a978321";

        [Header("數字")]
        [Range(0, 100)]
        [SerializeField]
        private int number = 77;

        [SerializeField, Header("是否開門")]
        private bool isOpen = false;

    }
}
