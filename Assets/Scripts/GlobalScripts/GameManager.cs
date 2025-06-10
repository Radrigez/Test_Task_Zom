using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float spawnRange = 5f;
    public int enemyCount;
    public int waveNumber = 3;
    
    public GameObject enemy1;
    public GameObject enemy2;
    
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    void Start()
    {
        SpawnEnemyWave(waveNumber);
    }


    void Update()
    {
        enemyCount =  FindObjectsOfType<NPC>().Length;
        if(enemyCount == 0) 
        {
            waveNumber++;  
            SpawnEnemyWave(waveNumber);
            Instantiate(item1, GenerationSpawnPosition(), item1.transform.rotation); 
            Instantiate(item2, GenerationSpawnPosition(), item2.transform.rotation);
            Instantiate(item3, GenerationSpawnPosition(), item3.transform.rotation); 

        }
    }


    public void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
    
    
    private void SpawnEnemyWave(int eminuesTOSpown)
    {
        for (int i = 0; i < eminuesTOSpown; i++ )
        {
            Instantiate(enemy1, GenerationSpawnPosition(), transform.rotation);
            Instantiate(enemy2, GenerationSpawnPosition(), transform.rotation);
        }
    }
    private Vector3 GenerationSpawnPosition() 
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosY = Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPosition = new Vector3(spawnPosX, spawnPosY, 0);
        return spawnPosition;
    }
}
