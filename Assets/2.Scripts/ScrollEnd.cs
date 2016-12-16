using UnityEngine;
using System.Collections;

public class ScrollEnd : MonoBehaviour {

    public GameObject obj;

    void OnScrollEnd()
    {
        obj.transform.localPosition = new Vector3(Random.Range(5, 13), Random.Range(5, 13), 0);
    }
}
