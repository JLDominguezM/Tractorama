using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para cambiar de escena

public class SceneChange : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Farmer")) // Verifica si el objeto colisionado tiene el tag "Farmer"
        {
            SceneManager.LoadScene(2); // Cambia a la escena 2 (asegúrate de que esté agregada en el Build Settings) 
        }
    }
}