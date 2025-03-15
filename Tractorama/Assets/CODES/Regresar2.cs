using UnityEngine;
using UnityEngine.SceneManagement;

public class Regresar2 : MonoBehaviour
{
    public void Back()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        
    }
}
