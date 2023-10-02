using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class forCube : MonoBehaviour

{

    public int a;
    public int b;
    public float Speed = 10;


    public GameObject Sphere;
    public GameObject Cylinder;


    public GameObject cam;

    public GameObject bcam;

    void Start()
    {



    }

    // Update is called once per frame
    void FixedUpdate()

    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
    }


    public void button()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


 
       
    }



