using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject islandOn;
    public GameObject island1;
    public GameObject island2;
    public GameObject island3;
    public GameObject island4;
    public GameObject island5;
    public GameObject island6;
    public GameObject island7;
    public GameObject island8;

    public int islandNumber;
    public int islandRandom;
    public int islandsSpawned;

    public GameObject plat1;
    public GameObject plat2;
    public GameObject plat3;
    public GameObject plat4;
    public GameObject plat5;
    public GameObject plat6;
    public GameObject plat7;
    public GameObject plat8;

    public List<GameObject> platformPrefabList = new List<GameObject>();

    void Start()
    {

    }

    void Update()
    {
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Island On"))
        {
            other.gameObject.tag = ("Island Other");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Island Other"))
        {
            other.gameObject.tag = ("Island On");
            islandOn = GameObject.FindWithTag("Island On");

            plat1 = null;
            plat2 = null;
            plat3 = null;
            plat4 = null;
            plat5 = null;
            plat6 = null;
            plat7 = null;
            plat8 = null;

            GameObject[] platforms = GameObject.FindGameObjectsWithTag("Island Other");
            foreach (GameObject platform in platforms)
                GameObject.Destroy(platform);

            StartCoroutine(waitToSpawnPlatform());

            Vector3 offset1 = new Vector3(-5, -40, 5);
            Vector3 offset2 = new Vector3(0, -40, 5);
            Vector3 offset3 = new Vector3(5, -40, 5);
            Vector3 offset4 = new Vector3(5, -40, 0);
            Vector3 offset5 = new Vector3(5, -40, -5);
            Vector3 offset6 = new Vector3(0, -40, -5);
            Vector3 offset7 = new Vector3(-5, -40, -5);
            Vector3 offset8 = new Vector3(-5, -40, 0);

            island1.transform.position = islandOn.transform.position + offset1;
            island2.transform.position = islandOn.transform.position + offset2;
            island3.transform.position = islandOn.transform.position + offset3;
            island4.transform.position = islandOn.transform.position + offset4;
            island5.transform.position = islandOn.transform.position + offset5;
            island6.transform.position = islandOn.transform.position + offset6;
            island7.transform.position = islandOn.transform.position + offset7;
            island8.transform.position = islandOn.transform.position + offset8;

            int prefabIndex1 = Random.Range(0, platformPrefabList.Count - 1);
            int prefabIndex2 = Random.Range(0, platformPrefabList.Count - 1);
            int prefabIndex3 = Random.Range(0, platformPrefabList.Count - 1);
            int prefabIndex4 = Random.Range(0, platformPrefabList.Count - 1);
            int prefabIndex5 = Random.Range(0, platformPrefabList.Count - 1);
            int prefabIndex6 = Random.Range(0, platformPrefabList.Count - 1);
            int prefabIndex7 = Random.Range(0, platformPrefabList.Count - 1);
            int prefabIndex8 = Random.Range(0, platformPrefabList.Count - 1);



            // getting a random number - how many platforms should spawn?
            islandNumber = Random.Range(3, 9);


            for (int i = 1; i <= islandNumber; i++)
            {

                // getting a random number - which platform should i attempt to spawn?
                islandRandom = Random.Range(1, 9);

                if (islandRandom == 1)
                {
                    if (plat1 == null)
                    {
                        plat1 = island1;
                        Instantiate(platformPrefabList[prefabIndex1], island1.transform.position, island1.transform.rotation);
                        print("1");
                    }
                    else
                    {
                        i--;
                    }
                }
                if (islandRandom == 2)
                {
                    if (plat2 == null)
                    {
                        plat2 = island1;
                        Instantiate(platformPrefabList[prefabIndex2], island2.transform.position, island2.transform.rotation);
                        print("2");
                    }
                    else
                    {
                        i--;
                    }
                }
                if (islandRandom == 3)
                {
                    if (plat3 == null)
                    {
                        plat3 = island1;
                        Instantiate(platformPrefabList[prefabIndex3], island3.transform.position, island3.transform.rotation);
                        print("3");
                    }
                    else
                    {
                        i--;
                    }
                }
                if (islandRandom == 4)
                {
                    if (plat4 == null)
                    {
                        plat4 = island1;
                        Instantiate(platformPrefabList[prefabIndex4], island4.transform.position, island4.transform.rotation);
                        print("4");
                    }
                    else
                    {
                        i--;
                    }
                }
                if (islandRandom == 5)
                {
                    if (plat5 == null)
                    {
                        plat5 = island1;
                        Instantiate(platformPrefabList[prefabIndex5], island5.transform.position, island5.transform.rotation);
                        print("5");
                    }
                    else
                    {
                        i--;
                    }
                }
                if (islandRandom == 6)
                {
                    if (plat6 == null)
                    {
                        plat6 = island1;
                        Instantiate(platformPrefabList[prefabIndex6], island6.transform.position, island6.transform.rotation);
                        print("6");
                    }
                    else
                    {
                        i--;
                    }
                }
                if (islandRandom == 7)
                {
                    if (plat7 == null)
                    {
                        plat7 = island1;
                        Instantiate(platformPrefabList[prefabIndex7], island7.transform.position, island7.transform.rotation);
                        print("7");
                    }
                    else
                    {
                        i--;
                    }
                }
                if (islandRandom == 8)
                {
                    if (plat8 == null)
                    {
                        plat8 = island1;
                        Instantiate(platformPrefabList[prefabIndex8], island8.transform.position, island8.transform.rotation);
                        print("8");
                    }
                    else
                    {
                        i--;
                    }
                }
            }
        }
    }

    IEnumerator waitToSpawnPlatform()
    {
        yield return new WaitForSeconds(3.0f);
    }

}
