using UnityEngine;

public class TrapBehavior : MonoBehaviour
{
    private Trap trap;

    private void Awake()
    {
        trap = new Trap();
    }

    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<IPlayer>();
        trap.HandleCharacterEntered(player);
    }
}

public class Trap 
{
    public void HandleCharacterEntered(IPlayer player)
    {
        player.Health--;
    }
}
