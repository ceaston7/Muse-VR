using UnityEngine;
using System.Collections;

public class lookingAt : MonoBehaviour
{
    private RaycastHit hit;

    // Use this for initialization
    void Start()
    {
        Debug.Log("script working");
    }

    // Update is called once per frame
    void Update()
    {
        Physics.Raycast(transform.position, transform.forward, out hit);
        if (hit.collider != null && hit.collider.CompareTag("lift"))
        {
            Debug.Log("Looking at " + hit.collider.name);
            //hit.collider.GetComponent<mindMove>().move();
        }
    }
}