using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using socket.io;

public class SocketExample : MonoBehaviour {

    public string adress;
    public string nameSpace;
    public GameObject cube;



    // Use this for initialization
    void Start()
    {
        // news namespace
        var news = Socket.Connect(adress);
        news.On(SystemEvents.connect, () =>
        {
            Debug.Log("Hello, Socket.io~");
        });
        news.On("change color", (string color) =>
        {
            Debug.Log("red");
            if (color.Contains("red"))
            {
                cube.GetComponent<Renderer>().material.color = Color.red;
            }
            else if (color.Contains("blue"))            {
                cube.GetComponent<Renderer>().material.color = Color.blue;

            }
            else
            {
                cube.GetComponent<Renderer>().material.color = Color.white;
            }
        });
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
