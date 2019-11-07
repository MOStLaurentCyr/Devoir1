using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SQLite;

public class LeaderBoardLoading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Awake()
    {
        try
        {
            SQLiteConnection connect = new SQLiteConnection(@"..\StreamingAssets\Leaderboard.db");
        }
        catch
        {
            UnityEditor.EditorUtility.DisplayDialog("Connection to the Database has failed!", "ok", "damn!");
        }
    }
}
