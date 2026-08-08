using UnityEngine;

public class Finish : MonoBehaviour
{
   [SerializeField] 
   private GameObject gameOverScreen;

   public static Finish Instance;
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
        Time.timeScale = 0f;
    }

    public void ShowHideGameOverScreen(bool flag)
    {
        gameOverScreen.SetActive(flag);
        return;
    }

}
