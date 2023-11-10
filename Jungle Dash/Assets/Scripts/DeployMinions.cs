using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployMinions : MonoBehaviour
{
    [SerializeField] private GameObject minionPrefab;
    [SerializeField] private float respawnTime = 5f;
    private bool gameStage = true;
    private List<float> yCoordinatesOfSpawn = new List<float> {-1.35f , -2.9f};
    private Vector2 screenBounds;
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3 (Screen.width , Screen.height , Camera.main.transform.position.z));
        StartCoroutine(minionWave());
    }
    private void spawnEnemy(){
        GameObject temp = Instantiate(minionPrefab) as GameObject;
        temp.transform.position = new Vector2(screenBounds.x*2 , yCoordinatesOfSpawn[Random.Range(0,2)]);
    }
    IEnumerator minionWave(){
        while (gameStage)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
    void Update()
    {
        
    }
}
