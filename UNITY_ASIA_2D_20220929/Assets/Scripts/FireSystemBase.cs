using UnityEngine;

namespace RIA

{
    public class FireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("子彈預製物")]
        private GameObject prefabBullet;
        [SerializeField, Header("子彈生成點")]
        private Transform pointSpawn;

        // 自頂方法
        // 生成子彈
        // 保護級別：衝虛地類別存取
        protected void SpawnBullet()
        {
            //實列化（生成物件， 座標， 角度）；
            // 生成 子彈預製 座標與角度跟生成點相同
            
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
        }
    }
}
