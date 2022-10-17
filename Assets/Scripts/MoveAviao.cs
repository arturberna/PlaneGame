using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAviao : MonoBehaviour
{
    public GameObject aviao;
    public float velocidade = 1.15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(new Vector3(0,0.2f,0));
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(new Vector3(0,-0.2f,0));
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(new Vector3(-0.2f,0,0));
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(new Vector3(0.2f,0,0));
        }

    }
}
