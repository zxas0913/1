using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TopDownController : MonoBehaviour
{
    private float spead = 10.5f;
    private string parameterRun = "�}���]�B";
    private string parameterDead = "�}�����`";
    private Animator ani;
    private Rigidbody2D rig;

    private void Awake()
    {
        ani = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
    }
}
