using UnityEngine;

public class ReglaDeVida : MonoBehaviour
{
    [SerializeField] public int life = 10;

    private int Collider2D;
   
    void Start()
    {

    }

    void Update()
    {
      
    }

    public void EnemyDamage()
    {
        print("Resive Daño");
        life-= 2;
    }

    

}
