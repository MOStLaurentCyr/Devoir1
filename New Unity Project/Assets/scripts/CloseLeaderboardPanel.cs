using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseLeaderboardPanel : MonoBehaviour
{
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClosePanel()
    {
        if (Panel != null)
            Panel.SetActive(false);
    }
}
