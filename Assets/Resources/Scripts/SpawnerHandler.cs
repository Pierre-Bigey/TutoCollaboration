using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using RVC;
using TMPro;
using UnityEngine;

public class SpawnerHandler : MonoBehaviour
{
    [SerializeField] private TMP_Text Welcome_text;
    public GameManager GameManager;
    
    private Vector3 spawnPosition;
    
    private bool isBallSpawned = false;
    private string playerName;
    private Color playerColor;
    
    GameObject sphere;

    private void Start()
    {
        playerName = PlayerInfos.Instance.playerName;
        playerColor = PlayerInfos.Instance.playerColor;
        Welcome_text.text = "Welcome " + playerName+",";
    }


    public void PlaceSphere(Vector2 pos)
    {
        spawnPosition = new Vector3(pos.x*10, 1.5f, pos.y*10);
        Debug.Log("PlaceSphere at " + pos);
        
        if (sphere != null)
        {
            // Place the sphere at the new position
            sphere.transform.position = spawnPosition;
        }
        else
        {
            sphere = PhotonNetwork.Instantiate("Ball", spawnPosition, Quaternion.identity, 0) ;
        }
    }

    public void Spawn()
    {
        PhotonNetwork.Destroy(sphere);
        spawnPosition = new Vector3(spawnPosition.x, 0.5f, spawnPosition.z);
        GameManager.SummonRig(spawnPosition);
        this.gameObject.SetActive(false);
    }
}
