using UnityEngine;
using UnityEngine.SceneManagement;

public class Avanzar3 : MonoBehaviour
{
    public void Forward()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        
    }
}
