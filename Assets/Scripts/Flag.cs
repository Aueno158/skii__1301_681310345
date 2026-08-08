using UnityEngine;

public class Flag : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.gameObject.GetComponent<Player>();

        if (player == null)
            return;
        player.Point += 10;
        SoundManager.Instance.PlayCollectibleSound();
        UIManager.Instance.ShowNotiText($"+10 Points \npoints : {player.Point}");
            Destroy(gameObject);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
