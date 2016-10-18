/*using UnityEngine;
using System.Collections;
using SharpOSC;

public class MuseReader : MonoBehaviour {
    public static int alpha_val;
	// Use this for initialization
	void Start () {
        HandleOscPacket callback = delegate (OscPacket packet) {
            var messageReceived = (OscMessage)packet;
            var addr = messageReceived.Address;
        };
        var listener = new TCPListener(5000, callback);
    }
	
	// Update is called once per frame
	void Update () {
        //bring OSC data to Unity
        if (OscPacketIO.isOpen())
        {
            alpha_val = GetNumericValue("/mus/elements/alpha_relative", Int32);
            if (alpha_val > 0.2)
            {
                //raise box
            }
        }
    }
}
*/