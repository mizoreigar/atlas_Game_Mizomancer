using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bar_click_object : MonoBehaviour
{
    public GameObject[] objects;
    //public GameObject bar;
    public float x_max;
    public float x_min;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = new Vector3(Random.Range(x_min, x_max), 13.88f, 10f);
        int rand = Random.Range(0, objects.Length);

        //GameObject instance = (GameObject)Instantiate(objects[rand], transform.position, Quaternion.identity);
             
			gameObject.transform.position = new Vector3(0, 0, 0);
            //instance.transform.parent = transform;
			Instantiate(objects[rand], position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
