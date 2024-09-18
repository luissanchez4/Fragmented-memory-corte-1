using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DataInstance : MonoBehaviour
{
private static DataInstance instance;

    public Vector2 playerPosition;
    public static DataInstance Instance
    {
        get
        {
            if(instance == null)
            {
                GameObject go = new GameObject("DataInstance");
                instance = go.AddComponent<DataInstance>();
                DontDestroyOnLoad(go);
                instance.playerPosition = FindObjectOfType<PlayerMovement>().transform.position;
            }
            return instance;
        }
    }

  private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
public void SetPlayerPosition(Vector2 playerPosi)
{
    playerPosition = playerPosi;
}
}
