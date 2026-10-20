using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class inicio : MonoBehaviour
{
    public void Jugar()

    {
        SceneManager.LoadScene("jackelyn");

    }
    public void Salir()
    {
        Application.Quit();
    }
   
}
