
using UnityEngine;
using UnityEngine.SceneManagement;


public class PickUpOrb : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bat"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }
}
