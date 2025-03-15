using UnityEngine;
using UnityEngine.SceneManagement;

public class Regresar4 : MonoBehaviour
{
    public void Back()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
        
    }
}
