using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GenerarSecuencia : MonoBehaviour
{
    [SerializeField] Button[] botones;
    [SerializeField] public int[] secuencia = {0, 0, 0, 0, 0};
    [SerializeField] public int indiceActual;
    [SerializeField] public bool puedeJugar;
    [SerializeField] int random;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Secuencia());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Secuencia()
    {
        puedeJugar = false;
        yield return new WaitForSeconds(0.5f);
        random = Random.Range(0, botones.Length);

        for (int i = 0; i < botones.Length; i++)
        {
            botones[i].interactable = false;
        }

        for (int i = 0;i <= indiceActual;i++)
        {
            
            botones[secuencia[i]].interactable = true;
            yield return new WaitForSeconds(1);
            botones[secuencia[i]].interactable = false;
            if (secuencia[i] != indiceActual)
            {
                yield return new WaitForSeconds(1);
            }
        }
        for(int i = 0;i< botones.Length;i++)
        {
            botones[i].interactable = true;
        }
        indiceActual += 1;
        puedeJugar = true;
    }
}
