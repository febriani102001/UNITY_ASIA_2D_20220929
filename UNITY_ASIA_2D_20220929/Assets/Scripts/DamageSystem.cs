using UnityEngine;

namespace RIA
{
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("爆炸預製物")]
        private GameObject prefabExplosion;
        [SerializeField, Header("碰到會爆炸的名稱")]
        private string nameTarget;
        [Header("受傷與爆炸的音效")]
        [SerializeField]
        private AudioClip soundHit;
        [SerializeField]
        private AudioClip soundExplosion;


        private void OnCollisionEnter2D(Collision2D collision)
        {
            //print(collision.gameObejct.name);

            // if touch game object and nameTraget then explosion
            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);

                SoundManager.instance.PlaySound(soundHit, new Vector2(0.7f, 0.9f));
                SoundManager.instance.PlaySound(soundExplosion, new Vector2(1.2f, 1.5f));

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
