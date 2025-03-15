using UnityEngine;
using UnityEngine.SceneManagement;

public class Regresar : MonoBehaviour
{
    public void Back()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        
    }
}
