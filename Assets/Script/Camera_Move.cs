using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move : MonoBehaviour
{
    public GameObject gBird, pBird, rBird;
    public Transform[] Bird;
    int chBird;
    Vector3 posDif;
    // Start is called before the first frame update
    void Start()
    {
        chBird = PlayerPrefs.GetInt("chBird", 0);

        posDif = transform.position - Bird[chBird].position;

        switch (chBird)
        {
            case 0:
                gBird.SetActive(true);
                pBird.SetActive(false);
                rBird.SetActive(false);
                break;
            case 1:
                gBird.SetActive(false);
                pBird.SetActive(true);
                rBird.SetActive(false);
                break;
            case 2:
                gBird.SetActive(false);
                pBird.SetActive(false);
                rBird.SetActive(true);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(Bird[chBird].position.x + posDif.x, transform.position.y, transform.position.z);
        transform.position = newPos;
    }
}
