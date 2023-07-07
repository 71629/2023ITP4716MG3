using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VitoryPoint : MonoBehaviour
{
    [SerializeField] GameObject GameVictory, HiddenCamera, HitPointDisable;
    [SerializeField] GameObject BlackBox;
    // Start is called before the first frame update
    void Start()
    {
        BlackBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Destroy(HitPointDisable);
            Debug.Log("Victory");
        }
    }
}