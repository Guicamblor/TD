using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public Transform target;

    public float range = 15f;

    public Transform partQroda;

    public float turnSpeed = 5f;

    public string enemyTag = "Enemy"; //se quiser mudar a tag muda aqui

    public float fireRate = 1f;

    public GameObject bulletPrefab;

    public Transform firePoint;


    private float fireCountDown = 0f;

    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f); //ficar invocando depois do tempo estipulado no final
    }

    void UpdateTarget() //vai chamar a função para que as torres sigam o primeiro inimigo que se aproximar
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortesDistance = Mathf.Infinity;
        GameObject nearestEnemy = null; //nearestEnemy inimigo mais proximo
        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if(distanceToEnemy < shortesDistance) //caso o inimigo saia vai para o proximo inimigo
            {
                shortesDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if(nearestEnemy != null && shortesDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }
    }

    void Update()
    {
        if (target == null)
            return; //quando não tiver mais nenhum inimigo ele para

        Vector3 dir = target.position - transform.position; //rotacionar na direção do alvo
        Quaternion lookRotation = Quaternion.LookRotation(dir); //diz para onde olhar
        Vector3 rotation = Quaternion.Lerp(partQroda.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles; //pode olhar para todos os eixos e não armazena eles na rotação e em certa velocidade 
        partQroda.rotation = Quaternion.Euler(0f, rotation.y, 0f);

        if(fireCountDown <= 0f)
        {
            Shoot();
            fireCountDown = 1f / fireRate;
        }

        fireCountDown -= Time.deltaTime;
    }
    void Shoot()
    {
        GameObject bulletGo = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletGo.GetComponent<Bullet>();

        if (bullet != null)
            bullet.Seek(target);
        print("Shoot");
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
