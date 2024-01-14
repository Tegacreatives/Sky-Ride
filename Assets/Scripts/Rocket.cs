using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField]
    private float speed = 100;

    [SerializeField]
    private float lifetime = 20.0f;

    private float timeLastSmoke;
    private float pointsWorth = 1;
    private bool isMoving = false;

    public float PointsWorth { get => pointsWorth; set => pointsWorth = value; }
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
            pointsWorth += (Time.deltaTime) * 10;
            lifetime -= Time.deltaTime;
            if (lifetime < 0f)
            {
                Destroy(gameObject);
            }

            if (Time.deltaTime >= timeLastSmoke + 0.04f)
            {
                timeLastSmoke = Time.time;

            }
            transform.position += transform.forward * (speed * Time.deltaTime);
            transform.Rotate(new Vector3(0, 30 * Time.deltaTime, 0));
        }
    }
}
