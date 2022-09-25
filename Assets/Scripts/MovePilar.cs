using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePilar : MonoBehaviour
{
    public GameObject pilar;
    public float velocidade = 0.05f;
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         //código para mudar de direção
      //   int sinal = 1;
        if(pilar.transform.position.x > 10){
           velocidade*= -1;

        }else if(pilar.transform.position.x < -10)
           velocidade *=-1; 
        

        transform.Translate(new Vector2(velocidade*Time.deltaTime,0));

    }
}
