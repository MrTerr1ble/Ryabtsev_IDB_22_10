using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPbar : MonoBehaviour
{ 
    public Text HP_Counter;
    public int Health_Points = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        HP_Counter.text = Health_Points.ToString();
        if (Health_Points <= 0)
            Dead();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Health_Points--;
    }

    public void Dead()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

