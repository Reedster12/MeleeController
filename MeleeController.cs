using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeController : MonoBehaviour
{
    public float rotationSpeed;
    public GameObject blade;
    private bool attacking;


    private void Start()
    {
        attacking = false;
    }


    private void Update()
    {
        if (attacking)
        {
            blade.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            attacking = true;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            attacking = false;
        }
    }
}
