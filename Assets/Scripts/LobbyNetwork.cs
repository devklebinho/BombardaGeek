using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Pun.UtilityScripts;
using Photon.Realtime;
using UnityEngine.SceneManagement;
public class LobbyNetwork : MonoBehaviourPunCallbacks
{
    [SerializeField] LobbyManager lobbyManager;


    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    
    public override void OnConnectedToMaster()
    {
        Debug.Log("Chegou o Master");
        PhotonNetwork.JoinLobby();
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("Desconectou");
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Chegou no lobby");
    }

    //button
    public void CreateRoom()
    {
        RoomOptions roomOptions = new RoomOptions()
        {
            IsOpen = true,
            IsVisible = true,
            MaxPlayers = 2
        };
        
        PhotonNetwork.CreateRoom(lobbyManager.createRoomName.text, roomOptions);
        PhotonNetwork.JoinRoom(lobbyManager.createRoomName.text);
    }

    public override void OnCreatedRoom()
    {
        Debug.Log("Criou o Room");
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Entrou no Room");
        PhotonNetwork.LoadLevel("Game");
    }
}
