
using UnityEngine;


public class Bullet : MonoBehaviour
{
    public float angle = 45f;
    Vector3 velocity;
    Vector3 direction;
    float speed = 10f;
    


    public float bulletDamage = 10f;

    

    

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1);
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector3(Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad), 0);
        velocity = direction * speed;
        transform.position += velocity * Time.deltaTime;
    }

    public float TowerDamage
    {
        get { return bulletDamage; }
        set { bulletDamage = value; }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
   
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        

        if (enemy != null)
        {
            Debug.Log("Werkt dit");
            enemy.TakeDamage(bulletDamage);
        }

        Destroy(gameObject);
        
    }
}


