using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Defines the <see cref="UiController" />.
/// </summary>
public class UiController : MonoBehaviour
{
    // Start is called before the first frame update
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

    // Update is called once per frame
    /// <summary>
    /// The Update.
    /// </summary>
    internal void Update()
    {
    }

    /// <summary>
    /// The Hheart.
    /// </summary>
    /// <param name="heart">The heart<see cref="int"/>.</param>
    public void Hheart(int heart1)
    {
        heart.text = heart1 + "";
    }
}
