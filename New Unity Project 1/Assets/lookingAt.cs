using UnityEngine;
using System.Collections;

public class lookingAt : MonoBehaviour
{
    private RaycastHit hit;
    public Collider focus;

    // Use this for initialization
    void Start()
    {
        Debug.Log("script working");
        focus = null;
    }

    // Update is called once per frame
    void Update()
    {
        Physics.Raycast(transform.position, transform.forward, out hit);
        if (hit.collider != null && hit.collider.CompareTag("mind"))
        {
            hit.collider.GetComponent<Concentrating>().concentrating = true;
        }
        else if (hit.collider == null && focus != null && focus.CompareTag("mind"))
        {
            focus.GetComponent<Concentrating>().concentrating = false;
        }

        if (focus != hit.collider && focus != null && focus.CompareTag("mind"))
        {
            focus.GetComponent<Concentrating>().concentrating = false;
        }

        focus = hit.collider;
    }
}