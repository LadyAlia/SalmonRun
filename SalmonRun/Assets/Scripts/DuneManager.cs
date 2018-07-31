using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuneManager : MonoBehaviour {
    public GameObject[] DynePrefabs;

    private Transform PlayerTransform;
    private List<GameObject> ActiveDynes;
    private float SpawnX = 3.0f;
    private float SafeZone = 15.0f;
    private float DyneLeng = 10.0f;
    private int DynesOnScreen = 3;
    private int LastPrefabIndex = 0;

   
    void Start()
    {
        ActiveDynes = new List<GameObject>();
        PlayerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        for (int i = 0; i < DynesOnScreen; i++)
        {
            SpawnDyne();

        }
    }

    // Update is called once per frame
    void Update()
    {   // Player transform  and Dynes Spawn position.
        if (PlayerTransform.position.x - SafeZone > (SpawnX - DynesOnScreen * DyneLeng))
        {
            SpawnDyne();
            DeleteDyne();
        }
    }

    // Spawning Dynes.
    private void SpawnDyne(int PrefabIndex = -1)
    {
        GameObject Dyne;
        Dyne = Instantiate(DynePrefabs[RandomPrefabIndex()]) as GameObject;
        Dyne.transform.SetParent(transform);
        Dyne.transform.position = Vector3.right * SpawnX;
        SpawnX += DyneLeng;
        ActiveDynes.Add(Dyne);

    }

    // Deleting Dynes.
    private void DeleteDyne()
    {
        Destroy(ActiveDynes[0]);
        ActiveDynes.RemoveAt(0);

    }

    // Randomize spawning Roads. 
    private int RandomPrefabIndex()
    {
        if (DynePrefabs.Length <= 1)
            return 0;

        int RandomIndex = LastPrefabIndex;
        while (RandomIndex == LastPrefabIndex)
        {
            RandomIndex = Random.Range(0, DynePrefabs.Length);
        }

        LastPrefabIndex = RandomIndex;
        return RandomIndex;
    }



}

