using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpikesZone : MonoBehaviour
{
    [SerializeField] GameObject spikePrefab;
    
    [SerializeField] private List<GameObject> spikesSlots;
    private List<int> usedSlots = new List<int>();
    private List<GameObject> spikes = new List<GameObject>();

    public void GenerateSpikes(int spikesNbr)
    {
        ClearSpikes();

        if (spikesNbr > spikesSlots.Count)
        {
            spikesNbr = spikesSlots.Count - 1;
        }
        
        for (int i = 0; i < spikesNbr; i++)
        {
            int slot = Random.Range(0, spikesSlots.Count - 1);

            bool canSpawn = false;
            while (!canSpawn)
            {
                if (usedSlots.Contains(slot))
                {
                    slot = Random.Range(0, spikesSlots.Count - 1);
                }
                else
                {
                    canSpawn = true;
                }
            }
            
            usedSlots.Add(slot);
            spikes.Add(Instantiate(spikePrefab, spikesSlots[slot].transform.position, spikesSlots[slot].transform.rotation));
        }
    }

    void ClearSpikes()
    {
        if (spikes != null)
        {
            foreach (GameObject spike in spikes)
            {
                Destroy(spike);
            } 
        }
        
        spikes.Clear();
        usedSlots.Clear();
    }
}
