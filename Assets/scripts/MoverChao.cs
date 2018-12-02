using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverChao : MonoBehaviour
{

    private Material currentMaterial;
    private Vector3 personagem;
    public float velocidade;
    private float offset;
    // Use this for initialization
    void Start()
    {
        currentMaterial = GetComponent<Renderer>().material;
        //personagem = GameObject.Find("Your_Name_Here").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        offset += 0.001f;

        if(personagem.y < 27) { 
            currentMaterial.SetTextureOffset("_MainTex", new Vector2(offset * velocidade, 0));
        }
    }
}
