using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para cambiar de escena

public class SceneChange2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Seller")) // Verifica si el objeto colisionado tiene el tag "Farmer"
        {
            SceneManager.LoadScene(3); // Cambia a la escena 3 (asegúrate de que esté agregada en el Build Settings) 
        }
    }
}