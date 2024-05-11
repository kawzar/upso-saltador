using System;
using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
    [SerializeField] private float velocidadSalto = 50;
    [SerializeField] private float distanciaChequeoSuelo = 2;
    [SerializeField] private LayerMask mascaraSuelo;
    [SerializeField] private Rigidbody2D body;
    private bool estaEnElSuelo = true;
   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && estaEnElSuelo) // Si apretamos la barra de espacio
        {
            Saltar();
        }

        estaEnElSuelo = ChequeoSuelo();
    }

    private void Saltar()
    {
        body.AddForce(Vector2.up * velocidadSalto, ForceMode2D.Impulse);
    }

    private bool ChequeoSuelo()
    {
        var raycast = Physics2D.RaycastAll(transform.position, Vector2.down, distanciaChequeoSuelo, mascaraSuelo);
        return raycast.Length > 0;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(transform.position, Vector2.down);
    }
}
