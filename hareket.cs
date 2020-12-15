using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class hareket : MonoBehaviour
{
    private int speed=1;
    public GameObject rollas;
    private float y;
    private Vector3 pos;  
    private Vector3 rotateValue;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        y = Input.GetAxis("Mouse X");
        rotateValue = new Vector3(0, -1*y, 0);
        transform.eulerAngles = transform.eulerAngles - rotateValue;
        
        Vector3 pos = transform.position;
        /*
        Debug.Log("Acının degeridir.");
        Debug.Log(gameObject.transform.rotation.eulerAngles.y);
        */
        Debug.Log(Math.Sin(DegreeToRadian(gameObject.transform.rotation.eulerAngles.y*2)));
        if (Input.GetKey ("w")) {
            pos.z += speed * Time.deltaTime*Convert.ToSingle(Math.Cos(DegreeToRadian(gameObject.transform.rotation.eulerAngles.y*2)));
            pos.x += speed * Time.deltaTime*Convert.ToSingle(Math.Sin(DegreeToRadian(gameObject.transform.rotation.eulerAngles.y*2)));
            
            
            
        }
        if (Input.GetKey ("s")) {
            pos.z -= speed * Time.deltaTime*Convert.ToSingle(Math.Cos(DegreeToRadian(gameObject.transform.rotation.eulerAngles.y*2)));
            pos.x -= speed * Time.deltaTime*Convert.ToSingle(Math.Sin(DegreeToRadian(gameObject.transform.rotation.eulerAngles.y*2)));
        }
        if (Input.GetKey ("d")) {
            pos.z -= speed * Time.deltaTime*Convert.ToSingle(Math.Cos(DegreeToRadian(90-gameObject.transform.rotation.eulerAngles.y*2)));
            pos.x += speed * Time.deltaTime*Convert.ToSingle(Math.Sin(DegreeToRadian(90-gameObject.transform.rotation.eulerAngles.y*2)));
        }
        if (Input.GetKey ("a")) {
            pos.z += speed * Time.deltaTime*Convert.ToSingle(Math.Cos(DegreeToRadian(90-gameObject.transform.rotation.eulerAngles.y*2)));
            pos.x -= speed * Time.deltaTime*Convert.ToSingle(Math.Sin(DegreeToRadian(90-gameObject.transform.rotation.eulerAngles.y*2)));
        
        }
             
 
         transform.position = pos;
    }

    private double DegreeToRadian(double angle)
    {
    return Math.PI * angle / 180.0;
    }
    void adim(){
        pos.y+=speed*Time.deltaTime*(0.25f);
        
        pos.y-=speed*Time.deltaTime*(0.25f);
    }
   
}
