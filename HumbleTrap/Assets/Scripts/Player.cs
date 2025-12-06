using UnityEngine;

public class Player : MonoBehaviour, IPlayer
{
    private CharacterController characterController;

    public int Health { get; set; }

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * 0.01f;
        float vertical = Input.GetAxis("Vertical") * 0.01f;
        characterController.Move(new Vector3(horizontal, 0, vertical));
    }
}
