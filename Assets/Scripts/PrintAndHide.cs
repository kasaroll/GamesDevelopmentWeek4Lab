using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public int i;
    public Renderer rend;
    public int randNum;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        randNum = Random.Range(200, 250);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ": " + i);

        if (gameObject.tag.Equals("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }

        if (gameObject.tag.Equals("Blue") && i == randNum)
        {
            rend.enabled = false;
        }

        i++;
    }
}
