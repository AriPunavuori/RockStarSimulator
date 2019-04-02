using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class TVRemote : MonoBehaviour {

    SteamVR_Action_Boolean useAction = SteamVR_Input.GetBooleanAction("Teleport");
    Interactable interactable;
    public GameObject videoPlayer;
    VideoPlayer vp;
    public bool button;
    bool prevButton;

    private void Awake() {
        interactable = GetComponent<Interactable>();
        vp = videoPlayer.GetComponent<VideoPlayer>();
    }

    void Update() {
        if(interactable.attachedToHand != null) {
            button = useAction.GetState(interactable.attachedToHand.handType);
        }
        if(button && !prevButton)
            PlayPause();
        prevButton = button;
    }

    public void PlayPause() {
        if(vp.isPlaying) {
            vp.Pause();
        } else {
            vp.Play();
        }
    }
}
