using UnityEngine;
using System.Collections;

public class CreateRandomMap : MonoBehaviour {
    public GameObject randomBlock = null;

    public float randomFirstPos;
    public float randomEndPos;

    void Start()
    {
        randomBlock.transform.Translate(Random.Range(randomFirstPos, randomEndPos), Random.Range(randomFirstPos, randomEndPos), 0);    
    }
    
}
