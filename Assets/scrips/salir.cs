using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class salir : MonoBehaviour
{
    public void VolverMenu(InputAction.CallbackContext value)
    {

        if (value.started)
        {
            SceneManager.LoadScene("Inicio");
        }

    }
    public void Escape(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            Application.Quit();
        }
    }
}
