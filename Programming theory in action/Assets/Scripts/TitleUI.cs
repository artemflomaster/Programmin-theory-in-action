using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleUI : MonoBehaviour
{
    public Toggle toBeOk;
    public Text okText;

    public void StartTheGame()
    {
        if (toBeOk.isOn)
        {
            SceneManager.LoadScene("Main");
        }
        else
        {
            okText.color = Color.red;
            Debug.Log("HIT");
        }


        
    }





}
