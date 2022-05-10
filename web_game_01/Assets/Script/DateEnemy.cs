using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KID
{
    [CreateAssetMenu(menuName = "KID/Date Enemy", fileName = "Date Enemy", order = 2)]
    public class DateEnemy : ScriptableObject
    {
        [Header("移動速度"), Range(0, 50)]
        public float spead = 30;
        [Header("攻擊力"), Range(0, 500)]
        public float attack = 10;
        [Header("攻擊冷卻"), Range(0, 7)]
        public float cd = 3.5f;
        [Header("血量"), Range(0, 5000)]
        public float hp =100;
        [Header("掉落經驗值機率"), Range(0, 1)]
        public float expDropProbability = 0.8f;
        [Header("掉落經驗值類型")]
        public TypeExp typeExp;       
    }
    public enum TypeExp
    {
        small, middle, big
    }
}