using UnityEngine;
using UnityEngine.SceneManagement;

public class Avanzar4 : MonoBehaviour
{
    public void Forward()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        
    }
}
