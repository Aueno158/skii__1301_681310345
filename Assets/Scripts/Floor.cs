using UnityEngine;

public class Floor : MonoBehaviour
{
    public static Floor Instance;
 private void OnTrigger(Collider other)
 {
  Player player = other.gameObject.GetComponent<Player>();
        if (player == null) 
            return;
            player.Hp -= 100;

             UIManager.Instance.ShowNotiText($"You fell off the platform! Should play again.");
        Time.timeScale = 0f;
         UIManager.Instance.ShowHideRestartButton(true);
 }
}



