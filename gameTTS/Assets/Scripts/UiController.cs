using UnityEngine;
using UnityEngine.UI;
public class UiController : MonoBehaviour
{
    public static UiController Instance;

    public Text heart;
    public Image LoadSence;
    internal void Start()
    {
    }

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    internal void Update()
    {
    }

    public void Hheart(int heart1)
    {
        heart.text = heart1 + "";
    }

    public void ClickPlay()
    {
        GameController.Instance.NextSence();
    }

    public void ClickJump()
    {
        PlayerController.Instance.isjump = true;
    }
}
