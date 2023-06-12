using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject DestroyVictory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (getYAxis() <= -1) //If some nice player make camera lower than sorry about that
        {
            Destroy(DestroyVictory); //GameOver
        }

    }
    public float getYAxis() // Get camera y position
    {                       // Normally camera y position in this map will not lower than 72
        return transform.position.y - 72;// So normally y position must higher than 72
    }
}
