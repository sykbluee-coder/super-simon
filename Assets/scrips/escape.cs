using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class escape : MonoBehaviour
{

    public void PulsarEscape (InputAction.CallbackContext value)
    {
        if ( value.started)
        {
            SceneManager.LoadScene("portada");
        }
    }
}
