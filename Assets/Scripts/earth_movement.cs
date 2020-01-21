using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earth_movement : MonoBehaviour
{
        
    public static int speeds=1;
    public static int counter=1;
    private bool movingRight = true;
    public static bool left =false;
    public static bool right = false;

    public int speedRotate = 5;
     public Rigidbody2D rb;
    // Start is called before the first frame update
    public void Start()
    {        
            rb.GetComponent<Rigidbody2D>();
            rb.gravityScale=0;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector2.right * speeds * Time.deltaTime);
        if(counter%2==1){
                
                        //transform.Translate(Vector2.right * speeds * Time.deltaTime);
                }else if(counter%2==0) {
                        //transform.Translate(Vector2.left * speeds * Time.deltaTime);
                       
                }

    }
    private void OnTriggerEnter2D(Collider2D trigger) {
            if (trigger.gameObject.tag=="leftmove"){
                    //counter=3;
                    right=true;
                    left=false;
		}
             else if (trigger.gameObject.tag=="rightmove"){
                    //counter=2;
                    left=true;
                    right=false;
		}   

             if(trigger.gameObject.tag=="gameover"){
                     transform.parent = null;
                      rb.gravityScale=2;
                      bar_movement.speed=0;
             }   
    }    
     
    public void Button(){
           /* if(left==true){
                    counter=2;
            }
            else if(right==true){
                    counter=3;
            } */
        //counter++;       
}
}