using UnityEngine;
using System.Collections;

public class mindMove : MonoBehaviour {
    public bool concentrating;
	
    // Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
       
	}

    public void move()
    {
        gameObject.transform.Translate(0f, 0f, 1f);
        if (concentrating && gameObject.transform.position.z < 30.0)
        {
            gameObject.transform.Translate(0f, 0f, 1f);
        }

        else if (!concentrating && gameObject.transform.position.z > 0.0)
        {
            gameObject.transform.Translate(0f, 0f, -1f);
        }
    }
}