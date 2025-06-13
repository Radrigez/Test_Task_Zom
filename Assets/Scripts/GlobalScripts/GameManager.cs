using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float spawnRange = 5f;
    public int enemyCount;
    public int waveNumber = 1;

    public GameObject[] enemy = new GameObject[2];
    public GameObject[] item = new GameObject[5];
    
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
            Instantiate(item[Random.Range(0,4)], GenerationSpawnPosition(), item[Random.Range(0,4)].transform.rotation); 
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
            Instantiate(enemy[Random.Range(0,2)], GenerationSpawnPosition(),transform.rotation);
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
