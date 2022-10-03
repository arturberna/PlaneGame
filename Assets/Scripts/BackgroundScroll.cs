using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float velocidade = 0.075f;
    public Renderer fundo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 deslocamento = new Vector2(velocidade*Time.deltaTime,0);
        fundo.material.mainTextureOffset+=deslocamento;
    }
}
