//one threshold
//raise a box
//threshold for engagement = Beta/(Alpha+Theta)
//average, peaks
//scale for engagement, follows the box, more engaged = higher box

//pull muse file of data eeg continuously
//signal unity to raise box, do nothing, etc
//adjusted from http://developer.choosemuse.com/research-tools-example/grabbing-data-from-museio-a-few-simple-examples-of-muse-osc-servers#c%23

using System;
using SharpOSC;

namespace muse_osc_server {
	class MainClass {
		public static void Main(string[] args) {
			// Callback function for received OSC messages. 
			// Prints EEG and Relative Alpha data only.
			HandleOscPacket callback = delegate(OscPacket packet) {
				var messageReceived = (OscMessage)packet;
				var addr = messageReceived.Address;
				if(addr == "/muse/eeg") {
					Console.Write("EEG values: ");
					foreach(var arg in messageReceived.Arguments) {
						Console.Write(arg + " ");
					}
				}
				if(addr == "/muse/elements/alpha_relative") {
					Console.Write("Relative Alpha power values: ");
					foreach(var arg in messageReceived.Arguments) {
						Console.Write(arg + " ");
					}
				}
			};
			// Create an OSC server.
			var listener = new TCPListener(5000, callback);
			//bring OSC data to Unity
			if (OscPacketIO.isOpen()) {
				alpha_val = GetNumericValue("/mus/elements/alpha_relative", Int32);
				if(alpha_val > 0.2) {
					//raise box
				}
			}
			Console.WriteLine("Press enter to stop");
			Console.ReadLine();
			listener.Close();
		}
	}
}