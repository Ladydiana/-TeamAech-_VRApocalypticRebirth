using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    [SerializeField]
    private GameObject mainMenuCanvas;
    [SerializeField]
    private GameObject inventoryCanvas;
    [SerializeField]
    private GameObject questUpdateCanvas;
    [SerializeField]
    private GameObject explorationAchievement;
    [SerializeField]
    private GameObject explorationIcon;
    [SerializeField]
    private GameObject helperAchievement;
    [SerializeField]
    private GameObject helperIcon;
    [SerializeField]
    private GameObject dialogueCanvas;
    [SerializeField]
    private GameObject responseCanvas;
    
    public Text questTextScreen;
    public Text questTextMenu;
    public Text dialogueText;

    private void Start()
    {
        questTextMenu.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            ActivateMainMenuCanvas();
        }
    }

    public void ActivateMainMenuCanvas()
    {
        mainMenuCanvas.SetActive(true);
        if (!inventoryCanvas.activeInHierarchy)
        {
            mainMenuCanvas.GetComponent<LookAtCamera>().UILookAtCamera();
        }
        inventoryCanvas.SetActive(false);
    }

    public void ActivateInventoryCanvas()
    {
        Vector3 position = mainMenuCanvas.transform.position;
        Quaternion rotation = mainMenuCanvas.transform.rotation;
        mainMenuCanvas.SetActive(false);
        inventoryCanvas.SetActive(true);
        inventoryCanvas.transform.position = position;
        inventoryCanvas.transform.rotation = rotation;
    }

    public void ActivateMapCanvas()
    {
        mainMenuCanvas.SetActive(false);
        inventoryCanvas.SetActive(false);
    }

    public void ActivateQuestUpdate()
    {
        questUpdateCanvas.SetActive(true);
        questUpdateCanvas.GetComponent<LookAtCamera>().UILookAtCamera();
        Invoke("DeactivateQuestUpdate", 3);
        mainMenuCanvas.SetActive(false);
        inventoryCanvas.SetActive(false);
    }

    public void ActivateExplorationAchievement()
    {
        if(explorationIcon.activeSelf == false)
        {
            explorationAchievement.SetActive(true);
            explorationIcon.SetActive(true);
            explorationAchievement.GetComponent<LookAtCamera>().UILookAtCamera();
            Invoke("DeactivateExplorationAchievement", 3f);
            mainMenuCanvas.SetActive(false);
            inventoryCanvas.SetActive(false);
        }
    }

    public void ActivateHelperAchievement()
    {
        if (helperIcon.activeSelf == false)
        {
            helperAchievement.SetActive(true);
            helperIcon.SetActive(true);
            helperAchievement.GetComponent<LookAtCamera>().UILookAtCamera();
            Invoke("DeactivateHelperAchievement", 3f);
            mainMenuCanvas.SetActive(false);
            inventoryCanvas.SetActive(false);
        }
    }

    public void ActivateDialogueCanvas()
    {
        dialogueCanvas.SetActive(true);
    }

    public void ActivateResponseCanvas()
    {
        responseCanvas.SetActive(true);
    }

    public void DeactivateQuestUpdate()
    {
        questUpdateCanvas.SetActive(false);
    }

    public void DeactivateExplorationAchievement()
    {
        explorationAchievement.SetActive(false);
    }

    public void DeactivateHelperAchievement()
    {
        helperAchievement.SetActive(false);
    }

    public void DeactivateDialogueCanvas()
    {
        dialogueCanvas.SetActive(false);
    }

    public void DeactivateResponseCanvas()
    {
        responseCanvas.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
