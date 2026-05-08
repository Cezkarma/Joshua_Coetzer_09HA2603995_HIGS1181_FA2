using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] int numberOfEnemiesToSpawn;
    [SerializeField] GameObject winCanvas;
    [SerializeField] GameObject enemiesLeftPanel;
    [SerializeField] GameObject controlsPanel;
    [SerializeField] TextMeshProUGUI enemyAmountLabel;

    private int numberOfEnemiesKilled = 0;

    private void Awake()
    {
        if (GameManager.Instance == null)
        {
            GameManager.Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        InitiateUI();
    }

    public int GetNumberOfEnemiesToSpawn()
    {
        return numberOfEnemiesToSpawn;
    }

    public void EnemyKilled()
    {
        numberOfEnemiesKilled++;
        enemyAmountLabel.text = (numberOfEnemiesToSpawn - numberOfEnemiesKilled).ToString();
        Debug.Log("Number of enemies killed: " + numberOfEnemiesKilled);

        if (numberOfEnemiesKilled >= numberOfEnemiesToSpawn)
        {
            Debug.Log("You win!!!");
            enemiesLeftPanel.SetActive(false);
            controlsPanel.SetActive(false); ///I added the controls panel after submitting my PDF but still within the deadline, so this line doesn't appear in my code snippet.
            winCanvas.SetActive(true);
        }
    }

    private void InitiateUI()
    {
        enemyAmountLabel.text = numberOfEnemiesToSpawn.ToString();
    }
}
