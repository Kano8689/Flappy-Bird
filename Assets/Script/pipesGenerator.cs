using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class pipesGenerator : MonoBehaviour
{
    public GameObject pipePrefab, pipeGnPoint;
    public Text Score;
    int point = 0;
    int mode;
    float rnPosX, rnPosY;
    //GameObject newPipe;

    // Start is called before the first frame update
    void Start()
    {
        Score.text = "" + point;
        mode = PlayerPrefs.GetInt("Mode", 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (mode == 1)
        {
            rnPosX = Random.Range(6, 11);
            rnPosY = Random.Range(-3.5f, 0.90f);
        }
        else if (mode == 2)
        {
            rnPosX = Random.Range(6, 9);
            rnPosY = Random.Range(-3.5f, 0.90f);
        }
        else
        {
            rnPosX = Random.Range(6, 7);
            rnPosY = Random.Range(-3.5f, 0.90f);
        }

        if (transform.position.x < pipeGnPoint.transform.position.x)
        {
            transform.position = new Vector2(transform.position.x + rnPosX, rnPosY);
            Instantiate(pipePrefab, transform.position, Quaternion.identity);
        }
    }

}
