using UnityEngine;
using UnityEngine.UI;

public class FeedbackManager : MonoBehaviour
{
    public Text feedbackText; // Assign the feedback Text

    private void Start()
    {
        // Start empty
        feedbackText.text = "";
    }

    public void UpdateFeedback(Color createdColor)
    {
        string colorName = GetColorName(createdColor);

        if (colorName == "Unknown Color")
        {
            feedbackText.text = ""; // No feedback if color is unrecognized
        }
        else
        {
            feedbackText.text = $"Created {colorName}!";
        }
    }

    private string GetColorName(Color color)
    {
        if (Approximately(color, new Color32(255, 128, 0, 255))) return "Orange";    // Orange
        if (Approximately(color, new Color32(51, 255, 204, 255))) return "Teal";      // Teal
        if (Approximately(color, new Color32(255, 51, 153, 255))) return "Magenta";   // Magenta
        if (Approximately(color, new Color32(51, 255, 255, 255))) return "Cyan";      // Cyan
        if (Approximately(color, new Color32(255, 0, 0, 255))) return "Red";          // Red
        if (Approximately(color, new Color32(255, 255, 51, 255))) return "Yellow";    // Yellow
        if (Approximately(color, new Color32(51, 204, 255, 255))) return "Blue";      // Blue
        if (Approximately(color, new Color32(102, 255, 51, 255))) return "Green";     // Green

        return "Unknown Color";
    }

    private bool Approximately(Color a, Color b)
    {
        return Mathf.Abs(a.r - b.r) < 0.1f &&
               Mathf.Abs(a.g - b.g) < 0.1f &&
               Mathf.Abs(a.b - b.b) < 0.1f;
    }

    public void ClearFeedback()
    {
        feedbackText.text = "";
    }

}
