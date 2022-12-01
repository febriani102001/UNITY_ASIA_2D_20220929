using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("控制前後速度的數值"), Range(0,20)]

    public float speed = 20;

    [Header("左右速度")]
    public float trunSpeed = 10;

    [Tooltip("這邊會顯示前後按鍵按下的數值")]
    public float VInput;
    public float H_Input;

    public float CrazyDriver;

    // Strat is called before the first frame update
    private void Start()
    {
        
    }


    void Update()
    {
        VInput = Input.GetAxis("Vertical");
        print("前後按鍵:" + VInput); //

        H_Input = Input.GetAxis("Horizontal");
        print("左右按鍵" + H_Input);

        transform.Translate(Vector3.forward * Time.deltaTime * speed * VInput);

        transform.Translate(Vector3.right * Time.deltaTime * trunSpeed * H_Input);

        CrazyDriver = Random.Range(-15, 15);
        print("CD:" + CrazyDriver);

        // Move the vehicle forward
        transform.Rotate(Vector3.up * Time.deltaTime * trunSpeed * CrazyDriver);

      
    }

   
}
