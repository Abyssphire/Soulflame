using UnityEngine;
using  UnityEngine.InputSystem;
public class PlayerMoviment : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private void Update()
    {
       //Moviment do player
       if (Input.GetKey(KeyCode.W))
       {
            transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
       }
       if (Input.GetKey(KeyCode.S))
       {
            transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);
       }
       if (Input.GetKey(KeyCode.A))
       {
            transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
       }
       if (Input.GetKey(KeyCode.D))
       {
            transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
       }
    }
    //tag do player para interagir com o NPC
    [SerializeField] private string playerTag = "Player";
    // Click do mouse para interagir com o NPC
    private void OnMouseDown()
    {
       if (Input.GetMouseButtonDown(0))
       {
            NpcInterativo npc = GetComponent<NpcInterativo>();
            if (npc != null)
            {
                npc.Interact();
            }
       }
    }
}
