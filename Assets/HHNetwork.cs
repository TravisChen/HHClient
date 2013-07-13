using UnityEngine;
using System.Collections;

public class HHNetwork : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Network.Connect("192.168.1.192",25000);
	}
	
	// Update is called once per frame
	void Update () {
		if( Network.connections.Length > 0 )
		{
			networkView.RPC ("SetOrientation", RPCMode.Server, Input.deviceOrientation.ToString(), SystemInfo.deviceUniqueIdentifier );
		}
	}
	
	[RPC]
    void SetOrientation( string orientation, string uniqueIdentifier ) {
    }
}


