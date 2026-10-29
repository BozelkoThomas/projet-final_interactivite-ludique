using UnityEngine;

public class CursorManager : MonoBehaviour
{
    void Start()
    {
        // Rend le curseur visible
        Cursor.visible = true;

        // Déverrouille le curseur pour qu'il puisse bouger librement sur l'écran
        Cursor.lockState = CursorLockMode.None;
    }
}
