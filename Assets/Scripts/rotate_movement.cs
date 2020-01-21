using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_movement : MonoBehaviour
{
   public static int counter=1;
public static float speed=10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(counter%2==1){
                transform.Rotate(new Vector3(0, 0, -speed*Time.deltaTime));
                        //transform.Translate(Vector2.right * speeds * Time.deltaTime);
                }else if(counter%2==0) {
                    transform.Rotate(new Vector3(0, 0, speed*Time.deltaTime));
                        //transform.Translate(Vector2.left * speeds * Time.deltaTime);
                       
                }

    }

    public void FixedUpdate()
    { 
        

    }
}
