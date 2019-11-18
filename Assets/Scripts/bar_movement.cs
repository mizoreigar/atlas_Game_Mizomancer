using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EZCameraShake;

public class bar_movement : MonoBehaviour
{
    public float speed=10;
    private bool movingRight = true;
    private bool greenisright = false;
    public GameObject bar;
    private int barCounter=0;

        
	public Text fpsText;
	public float deltaTime;
 

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
         Destroy(Instantiate(bar),0.2f);
         //earth_movement.speeds=0; 
         earth_movement.counter = Random.Range(1, 5);
    }

    // Update is called once per frame

    private void FixedUpdate() {
            Time.fixedDeltaTime=0.001f;
	     transform.Translate(Vector2.right * speed * Time.fixedDeltaTime);
            /* if(barCounter==4){
                    speed=10;
            }if(barCounter>4){
                    
                    barCounter=1;
            } */
            if(speed>50){
                    speed=50;
            }

            
                if(movingRight == false){
                       transform.eulerAngles= new Vector3(0,-180, 0);
                        //transform.Translate(Vector2.left * speed * Time.deltaTime);
                } else {
                       transform.eulerAngles = new Vector3(0, 0, 0);
                       // transform.Translate(Vector2.right * speed * Time.deltaTime);
                }
    }
    void Update()
    {
           
             deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
		float fps = 1.0f / deltaTime;
		fpsText.text = Mathf.Ceil(fps).ToString();   

            
        
               // if(Input.touchCount>0){
                //touch = Input.GetTouch(0);
                
        // }

        if (Input.GetMouseButtonDown(0)){
                       if(greenisright==true){
                        CameraShaker.Instance.ShakeOnce(3f, 3f, .18f, 1.1f);
                        //greenisright=false; 
                        barCounter++;
                        Destroy (GameObject.FindWithTag("green"));
                        
                        Destroy(Instantiate(bar),0.5f);
                        score_Counter.score +=1;
                        speed=speed+0.5f;
                        if(earth_movement.right==true){
                                earth_movement.counter=3;
                        }else if(earth_movement.left==true){
                                earth_movement.counter=2;
                        }
                        
                        //greenisright=false=;           
                }else if(greenisright==false){
                        earth_movement.speeds +=3;   
                        speed=speed+1;
                        barCounter=1;
                        //Destroy (GameObject.FindWithTag("green"));
                } 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
            if (collision.gameObject.tag =="left"){
                movingRight=true;
                speed=speed+1;
		} 
            if(collision.gameObject.tag =="right"){
              
                movingRight = false;
                  speed=speed+1;
                
            }

    }   
   public void OnTriggerEnter2D(Collider2D collision) {
           if(collision.gameObject.tag == "green"){
                greenisright=true;
                Debug.Log("true");
           }
           }
 public void OnTriggerExit2D(Collider2D other) {
         if(other.gameObject.tag == "green"){
                greenisright=false;
                Debug.Log("false");
 }
 }

  
   /* public void ButtonClick(){
            if(greenisright==true){
                        //greenisright=false; 
                        barCounter++;
                        Destroy (GameObject.FindWithTag("green"));
                        Destroy(Instantiate(bar),0.5f);
                        score_Counter.score +=1;
                        if(earth_movement.right==true){
                                earth_movement.counter=3;
                        }else if(earth_movement.left==true){
                                earth_movement.counter=2;
                        }
                        
                        //greenisright=false=;           
                }else if(greenisright==false){
                        earth_movement.speeds +=3;   
                        speed=speed+1;
                        barCounter=1;
                        //Destroy (GameObject.FindWithTag("green"));
                }
    }
*/
}