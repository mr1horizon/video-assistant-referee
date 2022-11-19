using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
	private LineRenderer lineRenderer;
	private GameObject TrackPath;
	public GameObject LocalPlayer;
	public GameObject MiniMapCam;
	public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
	lineRenderer = GetComponent<LineRenderer>();
	TrackPath = this.gameObject;
	int num_of_path = TrackPath.transform.childCount;
	lineRenderer.positionCount = num_of_path + 1;
	for (int x = 0; x<num_of_path;x++)
	{
		lineRenderer.SetPosition(x, new Vector3(TrackPath.transform.GetChild(x).transform.position.x, 4, TrackPath.transform.GetChild(x).transform.position.z));
	}
        
	lineRenderer.SetPosition(num_of_path, lineRenderer.GetPosition(0));

	lineRenderer.startWidth = 7f;
	lineRenderer.endWidth = 7f;
    }

    // Update is called once per frame
    void Update()
    {
	MiniMapCam.transform.position = (new Vector3(LocalPlayer.transform.position.x, MiniMapCam.transform.position.y, LocalPlayer.transform.position.z));
	Player.transform.position = (new Vector3(LocalPlayer.transform.position.x, Player.transform.position.y, LocalPlayer.transform.position.z));
    }
}
