public class Missile : monoBehaviour
{
    public float speed;

    void Update()
    {
        Destroy(gameObject, 3);
        transform.position += transform.forward*speed*Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        Destroy(enemy.gameObject)
        Destroy(gameObject);
    }
}
