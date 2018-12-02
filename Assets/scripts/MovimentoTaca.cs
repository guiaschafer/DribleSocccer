using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoTaca : MonoBehaviour {

    // Use this for initialization

    public float velocidade;
    public GameObject adversario;

    private bool passou;

    private MoverPersonagem personagem;

    void Start () {
        personagem = FindObjectOfType(typeof(MoverPersonagem)) as MoverPersonagem;

    }

    // Update is called once per frame
    void Update () {
        float dificuldade = 1;
        if (personagem.pontos > 100)
            dificuldade = personagem.pontos / 100;
        transform.position += new Vector3(velocidade * dificuldade, 0, 0) * Time.deltaTime;

        //if (transform.position.x < personagem.transform.position.x && !passou)
        //{
        //    personagem.AdicionarPontos(50);
        //    passou = true;
        //}
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        personagem.AdicionarPontos(50);
        adversario.SetActive(false);
    }
}
