using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ri : MonoBehaviour
{
    private Vector3 movement;

    [SerializeField] private float x = 0;
    [SerializeField] private float z = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        movement = new Vector3(x, 0f, z);
        transform.position += movement;
    }
}
