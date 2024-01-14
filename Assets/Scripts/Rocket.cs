using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField]
    private float speed = 100;
    private bool isMoving = false;

    public bool IsMoving { get => isMoving; set => isMoving = value; }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            transform.position += transform.forward * (speed * Time.deltaTime);
            transform.Rotate(new Vector3(0, 30 * Time.deltaTime, 0));
        }
    }
}
