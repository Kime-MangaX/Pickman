using UnityEngine;

public class ReglaDeVida : MonoBehaviour
{
    [SerializeField] public int life = 10;
    [SerializeField] public GameObject Enemy;

    private int Collider2D;
   
    void Start()
    {

    }

    void Update()
    {
      
    }

    /*public void EnemyDamage()
    {
        print("Resive Daño");
        life--;
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Enemy Colision : " + collision.tag);
        if (collision.tag == "Destrulle")
        {
            life--;
            if (life <= 0)
                Destroy(gameObject);
            print("Perdiste");
        }
    }

}
