using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KID
{
    /// <summary>
    /// 敵人系統
    /// </summary>

    public class EnemySys : MonoBehaviour
    {
        [SerializeField, Header("敵人資料")]
        private DateEnemy data;
        [SerializeField, Header("玩家物件名稱")]
        private string namePlayer = "player";

        private Transform traPlayer;
        

        private void Awake()
        {
            traPlayer = GameObject.Find(namePlayer).transform;

            float result = Mathf.Lerp(0, 100, 0.5f);
            print("0 與 100 的 0.5 插值結果:" + result);
        }
        float a = 0;
        float b = 1000;
        private void Update()
        {
            a = Mathf.Lerp(a, b , 0.5f);
            print("測試結果:" + a);
        }
    }









}
