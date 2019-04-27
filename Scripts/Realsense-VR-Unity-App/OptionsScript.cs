using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsScript : MonoBehaviour {

    public AvatarController tcp_server;
    public InputField offsetX, offsetY, offsetZ, divisorX, divisorY, divisorZ;
	// Use this for initialization
	void Start ()
    {
        offsetX.text = tcp_server.offsetX.ToString();
        offsetY.text = tcp_server.offsetY.ToString();
        offsetZ.text = tcp_server.offsetZ.ToString();

        divisorX.text = tcp_server.divisorX.ToString();
        divisorY.text = tcp_server.divisorY.ToString();
        divisorZ.text = tcp_server.divisorZ.ToString();
    }
	
    public void ChangeValues()
    {
        tcp_server.offsetX = float.Parse(offsetX.text);
        tcp_server.offsetY = float.Parse(offsetY.text);
        tcp_server.offsetZ = float.Parse(offsetZ.text);
        tcp_server.divisorX = float.Parse(divisorX.text);
        tcp_server.divisorY = float.Parse(divisorY.text);
        tcp_server.divisorZ = float.Parse(divisorZ.text);
    }
}
