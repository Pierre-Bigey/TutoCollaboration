using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class InteractiveCubeWithHandles : MonoBehaviourPun
{
    [Header("Handles")]
    [SerializeField] private GameObject topHandle;
    [SerializeField] private GameObject bottomHandle;
    [SerializeField] private GameObject leftHandle;
    [SerializeField] private GameObject rightHandle;
    [SerializeField] private GameObject frontHandle;
    [SerializeField] private GameObject backHandle;

    public bool view;
    
    
    void Update ()
    {
        view = photonView.IsMine;
        if (photonView.IsMine) {
            ComputePosition () ;
        }
    }
    
    void ComputePosition () {
        transform.position = (topHandle.transform.position +
              bottomHandle.transform.position +
              leftHandle.transform.position +
              rightHandle.transform.position +
              frontHandle.transform.position +
              backHandle.transform.position) / 6 ;
    }
}
