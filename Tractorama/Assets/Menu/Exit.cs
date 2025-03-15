using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void Quit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // Cierra en el Editor
        #else
            Application.Quit(); // Cierra en la build
        #endif
    }
}