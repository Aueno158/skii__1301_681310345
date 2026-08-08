using UnityEngine;

public class Finish : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.gameObject.GetComponent<Player>();
        if (player == null) 
            return;
        UIManager.Instance.ShowNotiText($"YOU WIN LMAO \nHP : {player.Hp}, Points : {player.Point}");
    }
}
