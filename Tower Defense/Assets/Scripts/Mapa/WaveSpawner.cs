using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{

    public Transform enemyPrefab;

    public Transform spawnPoint;//colocar onde inicia o prefab do Start

    public float timeBetweenWaves = 5f;

    public Text waveCountdownText;

    private float countdown = 2f;

    private int waveIndex = 0;
    void Update()
    {
        if(countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves; //tempo de cada wave
        }
        countdown -= Time.deltaTime;

        waveCountdownText.text = Mathf.Round(countdown).ToString();//tirando os decimais e fazendo com que apareça o numeros
        //tem a opção aqui em cima de Floor e Round(teste para ver)
    }

    IEnumerator SpawnWave()
    {
        waveIndex++;//faz com que suba/aumente as waves e aumente os inimigos somando ele com ele mesmo

        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }


    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation); //instanciar os inimigos e na posição certa
    }

    //codigo exemplo numOfEnemies = waves[waveNumber].count; (quantos ainda faltam)
    //codigo exemplo de numero de waves numOfEnemies= waveNumber * waveNumber + 1; ou numOfEnemies = waveNumber;
}
