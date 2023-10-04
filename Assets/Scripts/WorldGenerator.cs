using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    [Header("Configs")]
    public int gridX;
    public int gridZ;

    [Header("Piso")]
    [SerializeField] GameObject[] listaPiso;

    [Header("Paredes")]
    [SerializeField] GameObject[] listaParedes;


    void Start()
    {
        //GerarPiso();
    }

    void GerarPiso(Vector3 posicao, Quaternion rotacao)
    {
        int sort = Random.Range(0, listaPiso.Length);
        GameObject clone = Instantiate(listaPiso[sort], posicao, rotacao);
    }
}
