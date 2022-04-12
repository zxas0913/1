using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TopDownController : MonoBehaviour
{
    [SerializeField, Header("���ʳt��"),Range(0,100)]
    private float spead = 10.5f;
    private string parameterRun = "�}���]�B";
    private string parameterDead = "�}�����`";
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
        //print("���o�����b����:" + h);
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
