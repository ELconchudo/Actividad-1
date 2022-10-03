using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedorControl : MonoBehaviour
{

    public Transform[] cubos;
    public Transform[] esferas;
    public Vector3[] direcciones;
    // Start is called before the first frame update
    void Start()
    {

        direcciones = new Vector3[]
       {
        Vector3.right,
        Vector3.right,
        Vector3.right,
        Vector3.right
           };

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Z))
        {
            cubos[0].transform.position += Vector3.right;
        } else if (Input.GetKey(KeyCode.Q))
        {
            cubos[0].transform.position += Vector3.left;
        }else if (Input.GetKey(KeyCode.A))
        {
            cubos[0].transform.position += Vector3.up;
        }
       

        if (Input.GetKey(KeyCode.X))
        {
            cubos[1].transform.position += Vector3.right;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            cubos[1].transform.position += Vector3.left;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            cubos[1].transform.position += Vector3.up;
        }

        if (Input.GetKey(KeyCode.C))
        {
            cubos[2].transform.position += Vector3.right;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            cubos[2].transform.position += Vector3.left;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            cubos[2].transform.position += Vector3.up;
        }

        if (Input.GetKey(KeyCode.V))
        {
            esferas[0].transform.position += Vector3.right;
        }
        else if (Input.GetKey(KeyCode.R))
        {
            esferas[0].transform.position += Vector3.left;
        }
        else if (Input.GetKey(KeyCode.F))
        {
            esferas[0].transform.position += Vector3.up;
        }

        if (Input.GetKey(KeyCode.B))
        {
            esferas[1].transform.position += Vector3.right;
        }
        else if (Input.GetKey(KeyCode.T))
        {
            esferas[1].transform.position += Vector3.left;
        }
        else if (Input.GetKey(KeyCode.G))
        {
            esferas[1].transform.position += Vector3.up;
        }

        for (int i = 0; i < cubos.Length; i++) {
            if (Input.GetKey(KeyCode.Space))
            {
                cubos[i].transform.position = Vector3.zero;

            }else if (cubos[i].transform.position.x > 4)
            {
                cubos[i].transform.position = Vector3.zero;
            } else if (cubos[i].transform.position.y > 4)
            {
                cubos[i].transform.position = Vector3.zero;
            } else if (cubos[i].transform.position.x < -4)
            {
                cubos[i].transform.position = Vector3.zero;
            }else if (cubos[i].transform.position.y < -4)
            {
                cubos[i].transform.position = Vector3.zero;
            }
        }

        for (int i = 0; i < esferas.Length; i++)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                esferas[i].transform.position = Vector3.zero;

            }
            else if (esferas[i].transform.position.x > 4)
            {
                esferas[i].transform.position = Vector3.zero;
            }
            else if (esferas[i].transform.position.y > 4)
            {
                esferas[i].transform.position = Vector3.zero;
            }
            else if (esferas[i].transform.position.x < -4)
            {
                esferas[i].transform.position = Vector3.zero;
            }
            else if (esferas[i].transform.position.y < -4)
            {
                esferas[i].transform.position = Vector3.zero;
            }
        }

    }
}
