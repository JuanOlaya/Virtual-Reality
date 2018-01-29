using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;
using UnityEngine.Events;

[RequireComponent(typeof(VRInteractiveItem))]
public class VRItemEventHandler : MonoBehaviour {

    private VRInteractiveItem interactiveItem;
    public UnityEvent GazeEnterEvent;
    public UnityEvent GazeExitEvent;

    void Start ()
    {
        interactiveItem = GetComponent<VRInteractiveItem>();
        interactiveItem.OnOver += OnGazeEnter;
        interactiveItem.OnOut += OnGazeExit;
    }
	
	void Update () {
		
	}

    void OnGazeEnter()
    {
        //GazeEnterEvent.Invoke();
    }

    void OnGazeExit()
    {
        //GazeExitEvent.Invoke();
    }
}
