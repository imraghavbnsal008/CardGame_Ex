using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class main_menu_Switch : MonoBehaviour
{
    public void Switching(){
        SceneManager.LoadScene("MainMenu");
    }
}
