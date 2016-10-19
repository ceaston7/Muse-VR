using UnityEngine;
using System.Collections;

public class MindLift : MonoBehaviour {
    public bool concentrating;
    public bool touching = false;
    public bool above = false;
	
    // Use this for initialization
	void Start () {
        concentrating = gameObject.GetComponent<Concentrating>().concentrating;
    }
	
	// Update is called once per frame
	void Update () {
        concentrating = gameObject.GetComponent<Concentrating>().concentrating;
        if (concentrating && gameObject.transform.position.y < 5.0 && (!touching || !above))
        {
            gameObject.transform.Translate(Vector3.up * Time.deltaTime);
        }

        else if (!concentrating && gameObject.transform.position.y > 0.0 && (!touching || above))
        {
            gameObject.transform.Translate(Vector3.down * Time.deltaTime);
        }
        
    }

    void OnCollisionEnter(Collision x)
    {
        if (x.collider.transform.position.y > transform.position.y)
            above = true;
        else
            above = false;

        touching = true;
    }

    void OnCollisionExit(Collision x)
    {
        touching = false;
        above = false;
    }
}