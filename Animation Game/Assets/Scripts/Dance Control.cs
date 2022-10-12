using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceControl : MonoBehaviour
{
    // Set it to public to we can drag and drop objects animator
    public Animator CharAnimator;
    // Set it to public so we can adjust the total points and points in Unity
    public int totalpoints = 100;
    public int points = 0;
    // Start is called before the first frame update, Start of the scene
    void Start()
    {
        // Getting the attached animator
        CharAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame, Looping
    void Update()
    {
        //Getting the Mouse Button Down Click
        if (Input.GetMouseButtonDown(0)){
            //Getting the mouse position in Camera or screen
            //Making the mouse position to raycast
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Naming Raycast
            RaycastHit hit;
            //if the cursors raycast hit the Raycast of other object, float and integer
            //is the distance of raycast
            if (Physics.Raycast(ray, out hit, 100)) {
                //If the raycast of the other object have a tag what you are finding
                //execute code
                if(hit.collider.tag == "Dance1") {         
                    //Setting the animation boolean to true, execute dancing                
                    CharAnimator.SetBool("1stDance", true);             
                }
            }    
        }
        
    }
}
