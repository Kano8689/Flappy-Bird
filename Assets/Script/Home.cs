using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Home : MonoBehaviour
{
    public GameObject homeObject, slctModeObject, slctBirdObject, sooundManageObject;
    public AudioSource background;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickPlay()
    {
        SceneManager.LoadScene("Play");
    }

    public void onClickSelectMode()
    {
        homeObject.SetActive(false);
        slctModeObject.SetActive(true);
    }

    public void onClickSelectBird()
    {
        homeObject.SetActive(false);
        slctBirdObject.SetActive(true);
    }

    public void onClickSelectSoundManage()
    {
        homeObject.SetActive(false);
        sooundManageObject.SetActive(true);
    }

    public void SelectMode(int mode)
    {
        PlayerPrefs.SetInt("Mode", mode);

        slctModeObject.SetActive(false);
        homeObject.SetActive(true);
    }

    public void selectBird(int chBird)
    {
        PlayerPrefs.SetInt("chBird", chBird);
        homeObject.SetActive(true);
        slctBirdObject.SetActive(false);
    }
}

