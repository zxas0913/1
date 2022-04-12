using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TopDownController : MonoBehaviour
{
    [SerializeField, Header("移動速度"),Range(0,100)]
    private float spead = 10.5f;
    private string parameterRun = "開關跑步";
    private string parameterDead = "開關死亡";
    private Animator ani;
    private Rigidbody2D rig;
    private float h;
    private float v;

    private void Awake()
    {
        ani = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        GetInput();
        Move();
    }
    private void GetInput()
    {
        //float h = Input.GetAxis("Horizontal");
        //print("取得水平軸像值:" + h);
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
    }
    private void Move()
    {
        rig.velocity = new Vector2(h, v) * spead;
        ani.SetBool(parameterRun, h != 0 || v != 0);
        transform.eulerAngles = new Vector3(0, h >= 0 ? 0 : 180, 0);
        
    }

}
