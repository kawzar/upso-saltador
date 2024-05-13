using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void Update()
    {
        if (GameManager.Instance.EstaJugando)
        {
            Mover();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.Perder();
    }

    private void Mover()
    {
        transform.Translate(Vector2.left * (GameManager.Instance.RapidezActores * Time.deltaTime));
    }
}
