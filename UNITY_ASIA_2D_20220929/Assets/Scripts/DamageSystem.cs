using UnityEngine;

namespace RIA
{
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("爆炸預製物")]
        private GameObject prefabExplosion;
        [SerializeField, Header("碰到會爆炸的名稱")]
        private string nameTarget;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            //print(collision.gameObejct.name);

            // if touch game object and nameTraget then explosion
            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);
                // Destroy
                // gameObject
                Destroy(gameObject);
            }

        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            
        }

        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
    }
}
