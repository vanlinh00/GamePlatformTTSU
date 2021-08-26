using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Defines the <see cref="UiController" />.
/// </summary>
public class UiController : MonoBehaviour
{
    /// <summary>
    /// Defines the Instance.
    /// </summary>
    public static UiController Instance;

    /// <summary>
    /// Defines the heart.
    /// </summary>
    public Text heart;
   
    /// <summary>
    /// The Start.
    /// </summary>
    internal void Start()
    {
    }

    /// <summary>
    /// The Awake.
    /// </summary>
    private void Awake()
    {
        Instance = this;
    }

    /// <summary>
    /// The Update.
    /// </summary>
    internal void Update()
    {
    }

    /// <summary>
    /// The Hheart.
    /// </summary>
    /// <param name="heart1">The heart1<see cref="int"/>.</param>
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
        PlayerController.Instance.isjump=true;
    }    
}
