using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Progress;

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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SpriteOrb"))

        {
            Debug.Log("collide");
            PickUpItem(other.gameObject);
            SceneManager.LoadScene("Defeat");
        }

    }
    void PickUpItem(GameObject SpriteOrb)
    {

        Destroy(SpriteOrb);

    }

   
   
}
