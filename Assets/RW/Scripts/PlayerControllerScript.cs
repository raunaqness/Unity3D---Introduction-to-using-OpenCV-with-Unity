using UnityEngine;
using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class PlayerControllerScript: MonoBehaviour {

	Thread receiveThread;
	UdpClient client;
	int port;

	string lastReceivedUDPPacket = "";
	string allReceivedUDPPackets = "";

	Vector3 up;
	bool jump;

	public GameObject Player;

	void Start () 
	{

		up = new Vector3 (0f, 400f, 0f);
		jump = false;

		initUDP();
	}

	private void initUDP()
	{
		print ("UPDSend.init()");
		port = 5065;

		print ("Sending to 127.0.0.1 : " + port);

		receiveThread = new Thread (new ThreadStart(ReceiveData));
		receiveThread.IsBackground = true;
		receiveThread.Start ();

	}

	private void ReceiveData()
	{
		client = new UdpClient (port);
		while (true) 
		{
			try
			{
				IPEndPoint anyIP = new IPEndPoint(IPAddress.Parse("0.0.0.0"), port);
				byte[] data = client.Receive(ref anyIP);

				string text = Encoding.UTF8.GetString(data);
				print (">> " + text);
				lastReceivedUDPPacket=text;
				allReceivedUDPPackets=allReceivedUDPPackets+text;

				jump = true;

			}catch(Exception e){
				print (e.ToString());
			}
		}
	}

	public void Jump()
	{
		Player.GetComponent<Animator>().SetTrigger ("Jump");
	}

	public string getLatestUDPPacket()
	{
		allReceivedUDPPackets = "";
		return lastReceivedUDPPacket;
	}

	// Update is called once per frame
	void Update () 
	{
		if(jump == true)
		{
			Jump ();
			jump = false;
		}

	}

	void OnApplicationQuit(){
		if (receiveThread != null) {
			receiveThread.Abort();
		}
	}
}
