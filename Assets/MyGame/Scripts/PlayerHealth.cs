using UnityEngine;
public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public void TakeDamage(int damage)
    {
        health = health - damage;
    }
}