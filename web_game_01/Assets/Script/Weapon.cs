using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    /// <summary>
    /// 武器資料
    /// 1, 飛行速度
    /// 2, 攻擊力
    /// 3, 起始數量
    /// 4, 最大數量
    /// 5, 間隔時間
    /// 6, 生成位置
    /// <summary>
    [CreateAssetMenu(menuName = "KID/Date Weapon", fileName = "Date Weapon")]
    public class DateWeapon : ScriptableObject
    {
        [Header("飛行速度"), Range(0, 5000)]
        public float spead = 500;
        [Header("攻擊力"), Range(0, 100)]
        public float atack = 10;
        [Header("起始數量"), Range(1, 10)]
        public int contStart = 1;
        [Header("最大數量"), Range(1, 20)]
        public int countMax = 3;
        [Header("間隔時間"), Range(0, 5)]
        public float interval = 3.5f;

        [Header("生成位置")]
        public Vector3[] v3SpawnPoint;
    }
}
