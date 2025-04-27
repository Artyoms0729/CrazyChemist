using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;

public class ColorDropZone : MonoBehaviour, IDropHandler
{
    [Header("References")]
    public RawImage colorBoxRawImage;

    [Header("Win UI")]
    public GameObject winPopup; // Assign your Win Popup here

    [Header("Win Condition")]
    public Color targetColor; // Color the player must create

    private List<Color> currentColors = new List<Color>();

    private void Start()
    {
        colorBoxRawImage.color = Color.white;
        if (winPopup != null)
            winPopup.SetActive(false); // Hide the win popup at start
    }

    public void OnDrop(PointerEventData eventData)
    {
        DraggableColor draggedColor = eventData.pointerDrag.GetComponent<DraggableColor>();
        if (draggedColor != null)
        {
            currentColors.Add(draggedColor.color);
            UpdateColor();
        }
    }

    private void UpdateColor()
    {
        if (currentColors.Count == 0)
            return;

        float r = 0f, g = 0f, b = 0f;
        foreach (Color c in currentColors)
        {
            r += c.r;
            g += c.g;
            b += c.b;
        }
        r /= currentColors.Count;
        g /= currentColors.Count;
        b /= currentColors.Count;

        Color mixedColor = new Color(r, g, b, 1f);

        colorBoxRawImage.color = mixedColor;

        CheckWinCondition(mixedColor);
    }

    private void CheckWinCondition(Color mixedColor)
    {
        if (Approximately(mixedColor, targetColor))
        {
            Debug.Log("Correct Color Created!");
            if (winPopup != null)
                winPopup.SetActive(true); // Show Win Popup
        }
    }

    private bool Approximately(Color a, Color b)
    {
        return Mathf.Abs(a.r - b.r) < 0.1f &&
               Mathf.Abs(a.g - b.g) < 0.1f &&
               Mathf.Abs(a.b - b.b) < 0.1f;
    }

    public void ClearColors()
    {
        currentColors.Clear();
        colorBoxRawImage.color = Color.white;
    }
}
