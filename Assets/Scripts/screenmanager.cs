using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenmanager : MonoBehaviour
{
    public bool start = true;
    public bool game = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (start){
            Camera.main.transform.position = new Vector3 (0,0,-10);
            if (Input.GetKeyUp("space")){
                Camera.main.transform.position = new Vector3 (0,60,-10);
                game = true;
                start = false;
            }
        }
        
    }
}
