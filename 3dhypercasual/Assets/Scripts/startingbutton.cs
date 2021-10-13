using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startingbutton : MonoBehaviour
{
    public Animator popUp;
    public int count;
    public GameObject player;
   
    public void button() 
    {  
           popUp.SetTrigger("click");
           //Destroy(gameObject,8);  
           StartCoroutine(buttondelay());  
    }
    IEnumerator buttondelay()
    {
        yield return new WaitForSeconds(1.5f);
        player.GetComponent<Rigidbody>().useGravity = true;
        yield return new WaitForSeconds(7.799f);
        count++;
    }
}
