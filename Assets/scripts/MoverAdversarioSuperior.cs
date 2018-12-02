using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverAdversarioSuperior : MonoBehaviour
{

    // Use this for initialization
    public float alturaMaxima;
    public float alturaMinima;

    public float rateSpawn;
    private float currentRateSpawn;

    public int quantidadeMaximaObj;

    public GameObject prefabs;

    public List<GameObject> adversario;

    private float posicaoAleatoria;
    void Start()
    {
        for (int i = 0; i < quantidadeMaximaObj; i++)
        {
            var tempAdversario = Instantiate(prefabs) as GameObject;
            tempAdversario.SetActive(false);
            adversario.Add(tempAdversario);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        currentRateSpawn += Time.deltaTime;

        if (currentRateSpawn > rateSpawn)
        {
            currentRateSpawn = 0;
            Spawn();
        }
    }

    private void Spawn()
    {
        int rand = Random.Range(0, 9);

        if (rand < 5)
            posicaoAleatoria = alturaMinima;
        else
            posicaoAleatoria = alturaMaxima;
        

        GameObject tempAdv = null;

        for (int i = 0; i < quantidadeMaximaObj; i++)
        {
            if (!adversario[i].activeSelf)
            {
                tempAdv = adversario[i];
                break;
            }
        }

        if (tempAdv != null)
        {
            tempAdv.transform.position = new Vector3(15f, posicaoAleatoria, -0.6f);
            tempAdv.SetActive(true);
        }
    }
}
