using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Esta função é chamada automaticamente quando o objeto colide com algo que tenha Collider
    private void OnCollisionEnter(Collision collision)
    {
        // Destrói o próprio objeto (a bala)
        Destroy(gameObject);
    }
}