using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// </summary>
/// �Z���t��
/// 1, �]�w���a���o���Z��
/// 2, �ͦ��Z��
/// 3, �o�g�Z��
/// 4, �����O�x�s
/// </summary>
public class WeaponSys : MonoBehaviour
{
    [SerializeField, Header("�Z�����")]
    private DateWeapon dateWeapon;
    [SerializeField, Header("武器剩餘時間"), Range(0,10)]
    private float destroyWeaponTime = 3.5f;
    

    /// <summary>
    /// 計時器
    /// </summary>
    private float timer;
   
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        
        for (int i = 0; i < dateWeapon.v3SpawnPoint.Length; i++)
        {
          Gizmos.DrawWireSphere(transform.position + dateWeapon.v3SpawnPoint[i], 0.1f);  
        }
        
    }
    private void Start()
    {
        Physics2D.IgnoreLayerCollision(3,6);
        Physics2D.IgnoreLayerCollision(6,6);
        Physics2D.IgnoreLayerCollision(6,7);
    }
    private void Update()
    {
        SpawnWeapon();
    }
    private void SpawnWeapon()
    {
        timer += Time.deltaTime;
        ///print("經過的時間 : " + timer);
        if (timer >= dateWeapon.interval)
        {
            //print("生成武器");
            int random = Random.Range(0, dateWeapon.v3SpawnPoint.Length);
            Vector3 pos = transform.position + dateWeapon.v3SpawnPoint[0];
            GameObject temp = Instantiate(dateWeapon.goWeapon, pos, Quaternion.identity);
            temp.GetComponent<Rigidbody2D>().AddForce(dateWeapon.v3Direction * dateWeapon.spead);
            timer = 0;
            Destroy(temp, destroyWeaponTime);
        }
    }
    
    
}
