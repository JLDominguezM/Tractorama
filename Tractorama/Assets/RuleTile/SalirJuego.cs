using UnityEngine;
using UnityEngine.SceneManagement;

public class SalirJuego : MonoBehaviour
{
 public void QuitGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }   
}