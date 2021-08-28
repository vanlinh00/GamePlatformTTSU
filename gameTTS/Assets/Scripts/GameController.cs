using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameController Instance;
   // public GameObject UICanvas;
    void Start()
    {
        Instance = this;
    }
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
      //  DontDestroyOnLoad(UICanvas);
    }
    // Update is called once per frame
    void Update()
    {

    }
  public void NextSence()
    {
        SceneManager.LoadScene(1);
    } 
    public void LoadSenceAgain()
    {
        SceneManager.LoadScene(1);
    }
}
