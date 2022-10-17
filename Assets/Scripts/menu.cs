using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    public void CenaJogar()
    {
        SceneManager.LoadScene("joguinho");
    }


    public void creditos()
    {
        SceneManager.LoadScene("creditos");
    }

    public void FecharJogo()
    {

    }
}
