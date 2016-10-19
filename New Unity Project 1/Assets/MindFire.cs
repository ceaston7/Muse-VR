using UnityEngine;
using System.Collections;


public class MindFire : MonoBehaviour {
    public bool concentrating;
    public bool first = true;

    void Start () {
        concentrating = gameObject.GetComponent<Concentrating>().concentrating;
        gameObject.GetComponentInChildren<ParticleSystem>().Stop();
    }

    // Update is called once per frame
    void Update () {
        concentrating = gameObject.GetComponent<Concentrating>().concentrating;
        if (concentrating && first)
        {
            Debug.Log("move fire");
            gameObject.GetComponentInChildren<ParticleSystem>().Play();
            first = false;   
        }
        else if (first)
        {
            gameObject.GetComponentInChildren<ParticleSystem>().Stop();
        }
    }
}
