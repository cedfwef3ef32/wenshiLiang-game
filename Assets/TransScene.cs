using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void S1()
    {
        SceneManager.LoadScene("lws1");
    }
    public void S2()
    {
        SceneManager.LoadScene("lws2");
    }
    public void S3()
    {
        SceneManager.LoadScene("lws3");
    }
    public void S4()
    {
        SceneManager.LoadScene("lws4");
    }
    public void S5()
    {
        SceneManager.LoadScene("lws5");
    }
}
