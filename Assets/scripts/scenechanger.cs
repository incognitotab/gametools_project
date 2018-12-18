using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scenechanger : MonoBehaviour
{

    public void normalgame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void twoplayergame()
    {
        SceneManager.LoadScene("two player");
    }
    public void onepunch()
    {
        SceneManager.LoadScene("one punch mode");
    }
    public void onepunchtwoplayer()
    {
        SceneManager.LoadScene("one punch two player");
    }
}