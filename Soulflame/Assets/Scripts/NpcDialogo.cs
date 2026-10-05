using UnityEngine;
using TMPro;

public class NpcDialogo : MonoBehaviour
{
  public GameObject dialoguePanel; // Painel de diálogo
  public TextMeshProUGUI dialogueText; // Componente Tmp
  [TextArea]public string[] dialogueLines; // falas do npc
  private int lineIndex; // índice da linha atual do diálogo
  private bool isPlayerClose; // indica se o jogador está próximo do NPC

  void Start()
    {
        dialoguePanel.SetActive(false); // Desativa o painel de diálogo no início
    }
    void Update()
    {
        // Verifica se o jogador está próximo e pressionou a tecla "Enter"
        if (isPlayerClose && Input.GetKeyDown(KeyCode.Return))
        {
            if (!dialoguePanel.activeInHierarchy)
            {
                StartDialogue(); // Inicia o diálogo
            }
            else
            {
                NextDialogueLine(); // Exibe a próxima linha do diálogo
            }
        }
    }

    void StartDialogue()
    {
        dialoguePanel.SetActive(true); // Ativa o painel de diálogo
        lineIndex = 0; // Reinicia o índice da linha
        dialogueText.text = dialogueLines[lineIndex]; // Exibe a primeira linha do diálogo
    }

        void NextDialogueLine()
        {
       lineIndex++; // Avança para a próxima linha do diálogo
        if (lineIndex < dialogueLines.Length)
        {
            dialogueText.text = dialogueLines[lineIndex]; // Exibe a próxima linha do diálogo
        }
        else
        {
           dialoguePanel.SetActive(false); // Desativa o painel de diálogo quando todas as linhas foram exibidas
           lineIndex = 0; // Reinicia o índice da linha para o próximo diálogo
        }

        }
        // Detecta quando o jogador entra na área de interação do NPC
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                isPlayerClose = true; // Jogador está próximo
            }
        }

        private void 
    

  

    
}
