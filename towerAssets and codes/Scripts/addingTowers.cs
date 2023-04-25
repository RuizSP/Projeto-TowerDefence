using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class addingTowers : MonoBehaviour
{
    
    // Start is called before the first frame update
    public GameObject[] towers = new GameObject[6];
    public GameObject square;
    public static bool canadd;
    public Color cor;
   
    void Start()
    {
   
        
    }

    // Update is called once per frame
    void Update()
    {
       OnMouseButtonPressed();  
    }

    void OnMouseButtonPressed(){
        if (Input.GetMouseButtonDown(0) && canadd == true){
            Instantiate(towers[1],square.transform.position,Quaternion.Euler(0f,0f,90f));
        }
    }


}
