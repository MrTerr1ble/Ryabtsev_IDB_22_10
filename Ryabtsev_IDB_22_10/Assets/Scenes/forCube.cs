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

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Vector3.down * Speed * Time.deltaTime);
        }
    }


    public void button()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



}



