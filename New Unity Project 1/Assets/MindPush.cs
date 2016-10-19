using UnityEngine;
using System.Collections;

public class MindPush : MonoBehaviour {
    public bool concentrating;
	// Use this for initialization
	void Start () {
        concentrating = gameObject.GetComponent<Concentrating>().concentrating;

    }
	
	// Update is called once per frame
	void Update () {
        concentrating = gameObject.GetComponent<Concentrating>().concentrating;
        if (concentrating)
        {
            gameObject.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity + Vector3.Scale(GameObject.Find("FirstPersonCharacter").transform.forward.normalized, new Vector3(0.2f, 0.2f, 0.2f));
        }

    }
}
