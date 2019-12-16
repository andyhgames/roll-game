﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uniduino;
public class initialise_air : MonoBehaviour {





		public Arduino arduino; // arduino object 

		private  int pinRelay1 = 8; // pin that goes to the first relay
		private int  pinRelay2 = 11; // pin that goes to the second relay

		void Start( )
		{
			arduino = Arduino.global; // initialising arduino 
			arduino.Setup(ConfigurePins); // pin configuration 
		arduino.digitalWrite(pinRelay1,Arduino.HIGH); // no air flowing 
		arduino.digitalWrite(pinRelay2,Arduino.HIGH); // no air flowing
			
		}

		void ConfigurePins( ) // setting relay pins to output mode 
		{

			arduino.pinMode (pinRelay1, PinMode.OUTPUT);
			arduino.pinMode (pinRelay2, PinMode.OUTPUT);
		}

	void Update()
	{
		arduino.digitalWrite(pinRelay1,Arduino.HIGH); // no air flowing 
	  	arduino.digitalWrite(pinRelay2,Arduino.HIGH); // no air flowing 
	    }

}

