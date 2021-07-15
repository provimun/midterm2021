using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class munnymovement : MonoBehaviour
{

    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)){
            if(transform.position.x + speed < 11){
                transform.Translate(Vector3.right * speed);
            }
            else{
                transform.position = new Vector3(11, transform.position.y, transform.position.z);
            }
        }
        else if(Input.GetKey(KeyCode.LeftArrow)){
            if (transform.position.x - speed > -29){
                transform.Translate(Vector3.left * speed);
            }
            else{
                transform.position = new Vector3(-29, transform.position.y, transform.position.z);
            }
        }
    }
}
