using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedorControl : MonoBehaviour
{

    public Transform[] personajes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
            if (Input.GetKey(KeyCode.Keypad1))
            {
                if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
                {
                    personajes[0].transform.position += Vector3.left;
                } 
            else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) && personajes[0].transform.position.y >= 1) {

                    personajes[0].transform.position += Vector3.down;

                } else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {

                    personajes[0].transform.position += Vector3.right;
                } else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {

                    personajes[0].transform.position += Vector3.up;
                }
            }

        if (Input.GetKey(KeyCode.Keypad2))
        {
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
                {
                personajes[1].transform.position += Vector3.left;
            } else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) && personajes[1].transform.position.y >= 1) {

                personajes[1].transform.position += Vector3.down;

            } else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {

                personajes[1].transform.position += Vector3.right;
            } else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {

                personajes[1].transform.position += Vector3.up;
            }
        }

        if (Input.GetKey(KeyCode.Keypad3))
        {
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
                {
                personajes[2].transform.position += Vector3.left;
            } else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) && personajes[2].transform.position.y >= 1) {

                personajes[2].transform.position += Vector3.down;

            } else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {

                personajes[2].transform.position += Vector3.right;
            } else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {

                personajes[2].transform.position += Vector3.up;
            }
        }

        if (Input.GetKey(KeyCode.Keypad4))
        {
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
                {
                personajes[3].transform.position += Vector3.left;
            } else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) && personajes[3].transform.position.y >= 1) {

                personajes[3].transform.position += Vector3.down;

            } else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {

                personajes[3].transform.position += Vector3.right;
            } else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {

                personajes[3].transform.position += Vector3.up;
            }
        }

        for (int i = 0; i < personajes.Length; i++)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                personajes[i].transform.position = Vector3.zero;

            }



        }
}}
