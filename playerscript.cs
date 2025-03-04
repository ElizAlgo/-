public void TakeDamage(int damage)
{
   health -= damage;

    if(health > 0)
    {
        audioSource.PlayOneShot(damageSound);
    }
    else
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex);
    }
}
