using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour
{
    public int vida;
    public string cena;
    public int damage;

    public HealthBar healthBar;

    void Start()
    {
        healthBar.SetMaxHealth(vida);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            vida -= damage;
            print("Bateu");

            healthBar.SetHealth(vida);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            vida -= damage;
            print("Bateu");

            healthBar.SetHealth(vida);
        }

    }
}
