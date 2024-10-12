using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GameObject;


public class RotationPlanet : MonoBehaviour
{
    public float angle;
    public float rotSpeed;
    public GameObject Sun;
    private Vector3 posSun;
    // Start is called before the first frame update
    void Start()
    {
        posSun=Sun.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        angle = Time.deltaTime;
        transform.Rotate(0, angle, 0);

        transform.RotateAround(posSun, Vector3.up, rotSpeed);
    }
}
