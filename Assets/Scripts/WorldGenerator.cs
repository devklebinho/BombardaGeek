using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    [Header("Configs")]
    public int gridX;
    public int gridZ;
    public float offset = 1f;
    [SerializeField] Vector3 gridOrigin = Vector3.zero;

    [Header("Piso")]
    [SerializeField] GameObject[] listaPiso;

    [Header("Paredes")]
    [SerializeField] GameObject[] listaParedes;
    [Range(0f, 1f)]
    [SerializeField] float chanceDeGerar;


    void Start()
    {
        GerarMatriz();
    }

    void GerarMatriz()
    {
        for(int x = 0; x < gridX; x++)
        {
            for(int z = 0; z < gridZ; z++)
            {
                Vector3 local = new Vector3(x * offset, 0, z * offset) + gridOrigin;
                GerarPiso(local, Quaternion.identity);

                local.y = 2;
                GerarParedes(local, Quaternion.identity);
            }
        }
    }

    
    void GerarPiso(Vector3 posicao, Quaternion rotacao)
    {
        int sort = Random.Range(0, listaPiso.Length);
        GameObject clone = Instantiate(listaPiso[sort], posicao, rotacao);
    }

    void GerarParedes(Vector3 posicao, Quaternion rotacao)
    {
        float chanceToSpawn = Random.Range(0f, 1f);

        if(chanceToSpawn <= chanceDeGerar)
        {
            int sort = Random.Range(0, listaParedes.Length);
            GameObject clone = Instantiate(listaParedes[sort], posicao, rotacao);
        }

    }
}
