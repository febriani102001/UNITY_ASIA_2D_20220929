using UnityEngine;

namespace RIA
{
    /// <summary>
    /// Move
    /// </summary>
    public class Move : MonoBehaviour
    {
        [SerializeField, Header("動速度"), Range(-10, 0)]
        private float speed = -3.5f;

        private void Update()
        {
            // transform 指此物件的 Transform 物件
            // Translate(x, y, z) 位移
            // * 乘法
            // Time.deltaTime 每頓的時間
            transform.Translate(speed* Time.deltaTime, 0, 0);
        }
    }
    
}
