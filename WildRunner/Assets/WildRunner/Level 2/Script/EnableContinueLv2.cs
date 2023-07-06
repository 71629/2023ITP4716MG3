using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableContinueLv2 : MonoBehaviour
{
    [SerializeField] GameObject Check5;
    [SerializeField] GameObject ContinueButton;
    [SerializeField] float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        ContinueButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Check5 == null)
        {
            if (timer <= 3)
            {
                timer += Time.deltaTime;
            }
            else
            {
                ContinueButton.SetActive(true);
            }

            GetComponent<Animator>().enabled = true;
        }
    }
}
