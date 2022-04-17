using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
    /// �Z�����
    /// 1, ����t��
    /// 2, �����O
    /// 3, �_�l�ƶq
    /// 4, �̤j�ƶq
    /// 5, ���j�ɶ�
    /// 6, �ͦ���m
    /// <summary>
    [CreateAssetMenu(menuName = "KID/Date Weapon", fileName = "Date Weapon")]
    public class DateWeapon : ScriptableObject
    {
        [Header("����t��"), Range(0, 5000)]
        public float spead = 500;
        [Header("�����O"), Range(0, 100)]
        public float atack = 10;
        [Header("�_�l�ƶq"), Range(1, 10)]
        public int contStart = 1;
        [Header("�̤j�ƶq"), Range(1, 20)]
        public int countMax = 3;
        [Header("���j�ɶ�"), Range(0, 5)]
        public float interval = 3.5f;

        [Header("�ͦ���m")]
        public Vector3[] v3SpawnPoint;
        [Header("武器預製物")]
        public GameObject goWeapon;
        [Header("飛行方向")]
        public Vector3 v3Direction;
    }

