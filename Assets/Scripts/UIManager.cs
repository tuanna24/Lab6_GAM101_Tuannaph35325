using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public int Cherry = 0;
    public TextMeshProUGUI CherryText;
    public GameObject winPanel;
    private void UpdateCherryCount()
    {
        CherryText.SetText("" + Cherry.ToString());
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("Cherry"))
        {
            Cherry++;
            UpdateCherryCount();
            Destroy(collider2D.gameObject);
            if (Cherry == 5)
            {
                ShowWinPanel();
            }
        }
    }

    private void ShowWinPanel()
    {
        winPanel.SetActive(true);
        if (winPanel.GetComponentInChildren<TextMeshProUGUI>() != null)
        {
            winPanel.GetComponentInChildren<TextMeshProUGUI>().SetText("You Win    Cherries Collected: " + Cherry.ToString());
        }
    }

    void Start()
    {
        winPanel.SetActive(false);
        UpdateCherryCount();
    }
}
