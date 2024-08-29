using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

    public GameObject menuPanel;
    public GameObject player;
    public GameObject healthbarPanel;

    // Start is called before the first frame update
    void Start()
    {
        player.SetActive(false);
        healthbarPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartClick()
    {
        menuPanel.SetActive(false);
        player.SetActive(true);
        healthbarPanel.SetActive(true);
    }


}
