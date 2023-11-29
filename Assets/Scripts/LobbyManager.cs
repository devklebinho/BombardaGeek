using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LobbyManager : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] GameObject panelLogin;
    [SerializeField] GameObject panelLobby;


    [Header("Lobby Inputs")]
    public TMP_InputField playerName;
    public TMP_InputField createRoomName;
    public TMP_InputField joinRoomName;

    [Header("Feedbacks")]
    public TMP_Text connectionStatus;

    void Start()
    {
        panelLogin.SetActive(true);
        panelLobby.SetActive(false);
    }

    public void ActivePanelLogin()
    {
        panelLogin.SetActive(true);
        panelLobby.SetActive(false);
    }

    public void ActivePanelLobby()
    {
        panelLogin.SetActive(false);
        panelLobby.SetActive(true);
    }
}
