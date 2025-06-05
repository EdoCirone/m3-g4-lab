using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawCoin : MonoBehaviour
{
    [SerializeField] float mindis = 3;
    [SerializeField] int coinNumbers = 10;
    [SerializeField] int spawnRange = 10;
    int maxTentativi;
    int i;
    [SerializeField] GameObject coinPrefab;
    [SerializeField] List<GameObject> coinList;

    void Start()
    {

        SpawnCoin();

    }

    private void SpawnCoin()
    {

        while ( i < coinNumbers && maxTentativi < 100)
        {
            Vector2 spawnPosition = new Vector2(Random.Range(-spawnRange, spawnRange), Random.Range(-spawnRange, spawnRange));

            if (AcceptableCoin(spawnPosition))
            {

                GameObject coin = Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
                coinList.Add(coin);
                i++;
            }

            maxTentativi++;

            if (maxTentativi == 100)
            {
                Debug.Log("C'abbiamo provato!");
            }
        }


        //for (int i = 0; i <= coinNumbers; i++)
        //{
        //    Vector2 spawnPosition = new Vector2(Random.Range(-spawnRange, spawnRange), Random.Range(-spawnRange, spawnRange));

        //    if (AcceptableCoin(spawnPosition))
        //    {

        //        GameObject coin = Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
        //        coinList.Add(coin);

        //    }


        //}


    }

    bool AcceptableCoin(Vector2 spawnPosition)
    {

        foreach (GameObject precedentcoin in coinList)

        {

            float distance = Vector2.Distance(spawnPosition, precedentcoin.transform.position);

            if (distance < mindis)
            {
                return false;

            }


        }

        return true;

    }

}
