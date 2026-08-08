using UnityEngine;

public class Tree : MonoBehaviour
{

    private MeshRenderer rd;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rd = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
            rd.material.color = Color.red;
        Player player = collision.gameObject.GetComponent<Player>();

        if (player == null) 
            return;
        player.Hp -= 15;

        UIManager.Instance.ShowNotiText($"YOU Hurt Lol Damage :-15\nHP : {player.Hp}");

        if (player.Hp <= 0)
        {
            player.Hp = 0;
            UIManager.Instance.ShowNotiText($"YOU DIED LMAO \nHP : {player.Hp}");
            Time.timeScale = 0f;
            UIManager.Instance.ShowHideRestartButton(true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = new Color32(84, 55, 28, 255);
    }
}
