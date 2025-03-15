using UnityEngine;
using UnityEngine.SceneManagement;

public class Regresar3 : MonoBehaviour
{
    public void Back()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        
    }
}
