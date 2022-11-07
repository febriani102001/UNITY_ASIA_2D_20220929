using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{   
    [Header("游戲物件"), Tooltip("請放你要跟隨的游戲物件")]
    public GameObject player;

    [Header("攝影機扁移量")]
    public Vector3 offset = new Vector3(0, 5, -7); //

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset; //攝影機的座標加上 
    }
}
