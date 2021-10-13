using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public float speed = 6f;

    public float turnspeed = 2f;

    private GameObject rotate;

    public Animator Impact;
    public int time;
    public float Horizontalmove;

    
    
    private void OnTriggerEnter(Collider other) 
    {
       if(other.CompareTag("Spawn"))
       {
           Impact.SetTrigger("impact");
       }
       
    }

    
    // Yeni fonksiyon olustur bu fonksiyona for gonder ve 7 yi icine sok. Her dongu sonuna waitforsecaond ekle 1 er saniye ile ardindan bu kodu addlistener ile calistir.
    
    void Update()
    {
        Horizontalmove = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * Horizontalmove * speed);
        transform.Rotate(Vector3.up * Horizontalmove * turnspeed );

        if(transform.position.x < -3)
        {
            transform.position = new Vector3(-3,transform.position.y,transform.position.z);
        }     
        if(transform.position.x > 3)
        {
            transform.position = new Vector3(3,transform.position.y,transform.position.z);
        }  
        time = GameObject.Find("Button").GetComponent<startingbutton>().count;
          
        if(time > 0)
            {
                transform.position = transform.position + (transform.forward * speed * Time.deltaTime);
            }
        
    }
}
