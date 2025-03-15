using UnityEngine;
using UnityEngine.SceneManagement; // Include this to change scenes

public class TractorCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the Tractor collides with the Farmer
        if (collision.gameObject.CompareTag("Farmer"))
        {
            // Change the scene to "TIENDA"
            SceneManager.LoadScene("TIENDA");
        }
    }

    private void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Farmer"))
    {
        Debug.Log("Trigger detected with Farmer!");
        SceneManager.LoadScene("TIENDA");
    }
}

}
