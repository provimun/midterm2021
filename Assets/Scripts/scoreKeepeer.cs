using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreKeepeer : MonoBehaviour
{
    public bool start = true;
    public bool game = false;
    
    public int focus = 30;
    public int grades = 30;
    public int food = 30;
    public int sanity = 30;

    public bool distraction = false;
    public bool failure = false;
    public bool starvation = false;
    public bool insanity = false;

    public bool game_lost = false;
    public bool game_won = false;

    public TMPro.TextMeshProUGUI focus_stat;
    public TMPro.TextMeshProUGUI grades_stat;
    public TMPro.TextMeshProUGUI food_stat;
    public TMPro.TextMeshProUGUI sanity_stat;
    public TMPro.TextMeshProUGUI death_reason;

    void Start(){

    }
    
    void Update()
    {
        //title screen management
        if (start){
            start = true;
            game = false;
    
            focus = 30;
            grades = 30;
            food = 30;
            sanity = 30;

            distraction = false;
            failure = false;
            starvation = false;
            insanity = false;

            game_lost = false;
            game_won = false;

            Camera.main.transform.position = new Vector3 (0,0,-10);
            
            if (Input.GetKeyUp("space")){
                focus = 30;
                grades = 30;
                food = 30;
                sanity = 30;
                focus_stat.text = "focus: " + focus;
                grades_stat.text = "grades: " + grades;
                food_stat.text = "food: " + food;
                sanity_stat.text = "sanity: " + sanity;
                game = true;
                start = false;
            }
        }
        if (game){
            Camera.main.transform.position = new Vector3 (0,60,-10);
        }
    
        //win scenario
        if (grades >= 200){
        game_won = true;
        }

        //lose scenario
        else if (focus <= 0 || grades <= 0 || food <= 0 || sanity <= 0)
        {
            if (focus <= 0){
                distraction = true;
            }
            else if (grades <= 0){
                failure = true;
                distraction = false;
            }
            else if (food <= 0)
            {
                starvation = true;
                failure = false;
                distraction = false;
            }
            else if (sanity <= 0)
            {
                insanity = true;
                starvation = false;
                failure = false;
                distraction = false;
            }
            game_lost = true;
        }
        //lose screen
        if (game_lost){
        Camera.main.transform.position = new Vector3 (0,-60,-10);
            if (insanity){
                death_reason.text = "you went insane.";
            }
            if (starvation){
                death_reason.text = "you starved.";
            }
            if (failure){
                death_reason.text = "you dropped out.";
            }
            if (distraction){
                death_reason.text = "you got too distracted.";
            }

            if (Input.GetKeyUp("space")){
            Camera.main.transform.position = new Vector3 (0,0,-10);
            game = false;
            start = true;
            }
        }
        //win screen
        if (game_won)
        {
            Camera.main.transform.position = new Vector3 (0,-120,-10);

            if (Input.GetKeyUp("space")){
                Camera.main.transform.position = new Vector3 (0,0,-10);
                start = true;
            }
        }
    }

    void OnCollisionEnter2D (Collision2D col){
        if (col.gameObject.name == "adderall pickup(Clone)"){
            // +25 focus -5 sanity
            focus += 25;
            sanity -= 5;
            focus_stat.text = "focus: " + focus;
            grades_stat.text = "grades: " + grades;
            food_stat.text = "food: " + food;
            sanity_stat.text = "sanity: " + sanity;
            Debug.Log("focus: " + focus + " grades: " + grades + " food: " + food + " sanity: " + sanity);
        }
        if (col.gameObject.name == "gum pickup(Clone)"){
            // +10 food +5 focus
            food += 10;
            focus += 5;
            focus_stat.text = "focus: " + focus;
            grades_stat.text = "grades: " + grades;
            food_stat.text = "food: " + food;
            sanity_stat.text = "sanity: " + sanity;
            Debug.Log("focus: " + focus + " grades: " + grades + " food: " + food + " sanity: " + sanity);
        }
        if (col.gameObject.name == "banana pickup(Clone)"){
            // +15 food -5 focus
            food += 15;
            focus -= 5;
            focus_stat.text = "focus: " + focus;
            grades_stat.text = "grades: " + grades;
            food_stat.text = "food: " + food;
            sanity_stat.text = "sanity: " + sanity;
            Debug.Log("focus: " + focus + " grades: " + grades + " food: " + food + " sanity: " + sanity);
        }
        if (col.gameObject.name == "pizza pickup(Clone)"){
            // +20 food +10 sanity -10 focus -5 grades
            food += 20;
            sanity += 10;
            focus -= 10;
            grades -= 5;
            focus_stat.text = "focus: " + focus;
            grades_stat.text = "grades: " + grades;
            food_stat.text = "food: " + food;
            sanity_stat.text = "sanity: " + sanity;
            Debug.Log("focus: " + focus + " grades: " + grades + " food: " + food + " sanity: " + sanity);
        }
        if (col.gameObject.name == "music pickup(Clone)"){
            // +5 sanity +5 focus
            sanity += 5;
            focus += 5;
            focus_stat.text = "focus: " + focus;
            grades_stat.text = "grades: " + grades;
            food_stat.text = "food: " + food;
            sanity_stat.text = "sanity: " + sanity;
            Debug.Log("focus: " + focus + " grades: " + grades + " food: " + food + " sanity: " + sanity);
        }
        if (col.gameObject.name == "phone pickup(Clone)"){
            // +10 sanity -5 food -5 grades
            sanity += 10;
            food -= 5;
            grades -= 5;
            focus_stat.text = "focus: " + focus;
            grades_stat.text = "grades: " + grades;
            food_stat.text = "food: " + food;
            sanity_stat.text = "sanity: " + sanity;
            Debug.Log("focus: " + focus + " grades: " + grades + " food: " + food + " sanity: " + sanity);
        }
        if (col.gameObject.name == "controller pickup(Clone)"){
            // +15 sanity -10 grades -10 focus -10 food
            sanity += 15;
            grades -= 10;
            focus -= 10;
            food -= 10;
            focus_stat.text = "focus: " + focus;
            grades_stat.text = "grades: " + grades;
            food_stat.text = "food: " + food;
            sanity_stat.text = "sanity: " + sanity;
            Debug.Log("focus: " + focus + " grades: " + grades + " food: " + food + " sanity: " + sanity);
        }
        if (col.gameObject.name == "textbook pickup(Clone)"){
            // +15 grades -10 focus -5 food -5 sanity
            grades += 15;
            focus -= 10;
            food -= 5;
            sanity -= 5;
            focus_stat.text = "focus: " + focus;
            grades_stat.text = "grades: " + grades;
            food_stat.text = "food: " + food;
            sanity_stat.text = "sanity: " + sanity;
            Debug.Log("focus: " + focus + " grades: " + grades + " food: " + food + " sanity: " + sanity);
        }
        if (col.gameObject.name == "essay pickup(Clone)"){
            // +25 grades -10 sanity -10 food -15 focus
            grades += 25;
            sanity -=10;
            food -=10;
            focus -= 15;
            focus_stat.text = "focus: " + focus;
            grades_stat.text = "grades: " + grades;
            food_stat.text = "food: " + food;
            sanity_stat.text = "sanity: " + sanity;
            Debug.Log("focus: " + focus + " grades: " + grades + " food: " + food + " sanity: " + sanity);
        }
        if (col.gameObject.name == "laptop pickup(Clone)"){
            //  +40 grades -15 sanity -10 food -15 focus
            grades += 40;
            sanity -= 15;
            food -= 10;
            focus -= 15;
            focus_stat.text = "focus: " + focus;
            grades_stat.text = "grades: " + grades;
            food_stat.text = "food: " + food;
            sanity_stat.text = "sanity: " + sanity;
            Debug.Log("focus: " + focus + " grades: " + grades + " food: " + food + " sanity: " + sanity);
        }
    }
}
