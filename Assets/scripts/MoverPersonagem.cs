using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPersonagem : MonoBehaviour
{

    // Use this for initialization
    public GameObject personagem;
    public float alturaMaxima;
    public float alturaMinima;

    public float velocidade;
    public int pontos;

    public TextMesh pontuacao;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float transactionUpDown = Input.GetAxis("Vertical") * velocidade;
        //float transactionLeftRigth = Input.GetAxis("Horizontal") * velocidade;

        personagem.transform.Translate(0, transactionUpDown, 0);

        if (personagem.transform.position.y > alturaMaxima)
            personagem.transform.position = new Vector2(personagem.transform.position.x, alturaMaxima);

        if (personagem.transform.position.y < alturaMinima)
            personagem.transform.position = new Vector2(personagem.transform.position.x, alturaMinima);


        pontuacao.text = pontos.ToString();
    }


    public void AdicionarPontos(int p)
    {
        pontos += p;
    }
}
