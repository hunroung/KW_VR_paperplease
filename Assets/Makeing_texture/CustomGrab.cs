using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CustomGrab : XRGrabInteractable
{
    public Transform attach_left;
    public Transform attach_right;

    void start()
    {

    }

    protected override void OnSelectEntered(XRBaseInteractor interactor)
    {
        if (interactor.CompareTag("Left Hand"))
        {
            this.attachTransform = attach_left;
        }
        else if (interactor.CompareTag("Right Hand"))
        {
            this.attachTransform = attach_right;
        }
    }

    protected override void OnSelectExited(XRBaseInteractor interactor)
    {
        
    }

    protected override void OnActivate(XRBaseInteractor interactor)
    {

    }
}
