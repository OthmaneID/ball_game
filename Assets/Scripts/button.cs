using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    // Start is called before the first frame update
   public void Play()
    {
       SceneManager.LoadScene("Play1");
    }

    // Update is called once per frame
   public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
	public void Quit()
    {
        Application.Quit(0);
    }
}
