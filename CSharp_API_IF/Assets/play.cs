using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{
    [Header("移動速度"), Range(0, 1000)]
    public float speed = 5;

    public Animator ani;


    public void Move()
    {

        bool w = Input.GetKey(KeyCode.W);
        ani.SetBool("走路開關", w);

  




    }

    private void Update()
    {

        Move();
    }
    }