using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropperscript : MonoBehaviour
{
    public float hspeed = 1f;
    public float vspeed = .5f;
    int moveToX = 0;
    int moveToY = 0;
    public int maxX = 16;
    public int minX = -32;
    public int maxY = 105;
    public int minY = 94;

    public int object_index = 0;

    public bool drop = false;

    public GameObject adderall;
    public GameObject gum;
    public GameObject banana;
    public GameObject pizza;
    public GameObject music;
    public GameObject phone;
    public GameObject controller;
    public GameObject textbook;
    public GameObject essay;
    public GameObject laptop;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(minX,maxX), Random.Range(minY,maxY), transform.position.z);

        moveToX = (Random.Range(minX,maxX));
        moveToY = (Random.Range(minY,maxY));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < moveToX){
            if (transform.position.x + hspeed <= moveToX){
                transform.Translate(Vector3.right * hspeed);
            }
            else{
                transform.position = new Vector3(moveToX,transform.position.y,transform.position.z);
            }
        }
        if (transform.position.x > moveToX){
            if (transform.position.x - hspeed >= moveToX){
                transform.Translate(Vector3.left * hspeed);
            }
            else{
                transform.position = new Vector3(moveToX,transform.position.y,transform.position.z);
            }
        }
        if (transform.position.y < moveToY){
            if (transform.position.y + vspeed <= moveToY){
                transform.Translate(Vector3.up * vspeed);
            }
            else{
                transform.position = new Vector3(transform.position.x,moveToY,transform.position.z);
            }
        }
        if (transform.position.y > moveToY){
            if (transform.position.y - vspeed >= moveToY){
                transform.Translate(Vector3.down * vspeed);
            }
            else{
                transform.position = new Vector3(transform.position.x,moveToY,transform.position.z);
            }
        }
        if (transform.position.x == moveToX){
            drop = true;
            moveToX = Random.Range(minX,maxX);
        }
        if (transform.position.y == moveToY){
            moveToY = Random.Range(minY,maxY);
        }
        if (drop == true){
            int object_index = Random.Range(1,10);
            if (object_index == 1){
                Instantiate(adderall, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
                drop = false;
            }
            else if (object_index == 2){
                Instantiate(gum, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
                drop = false;
            }
            else if (object_index == 3){
                Instantiate(banana, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
                drop = false;
            }
            else if (object_index == 4){
                Instantiate(pizza, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
                drop = false;
            }
            else if (object_index == 5){
                Instantiate(music, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
                drop = false;
            }
            else if (object_index == 6){
                Instantiate(phone, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
                drop = false;
            }
            else if (object_index == 7){
                Instantiate(controller, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
                drop = false;
            }
            else if (object_index == 8){
                Instantiate(textbook, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
                drop = false;
            }
            else if (object_index == 9){
                Instantiate(essay, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
                drop = false;
            }
            else if (object_index == 10){
                Instantiate(laptop, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
                drop = false;
            }
        }
    }
}
