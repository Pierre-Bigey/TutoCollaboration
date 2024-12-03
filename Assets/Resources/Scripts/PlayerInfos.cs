using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInfos : MonoBehaviour
{
    public Color playerColor;
    
    public string playerName;

    public static PlayerInfos Instance;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }
}
