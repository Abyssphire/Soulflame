using UnityEngine;

public class NpcInterativo : MonoBehaviour
{
   // Variável para armazenar a mensagem do NPC
    [SerializeField] private string npcMessage = "Olá, jogador!";
    
    // Após o jogador interagir com o NPC, exibe a mensagem no console
    public void Interact()
    {
        Debug.Log(npcMessage);
    }
}
