using UnityEngine;
using System.Collections;

public class ScrollObject : MonoBehaviour {
    public float speed = 3.0f;
    public float startPosition;
    public float endPosition;

    void Awake()
    {
        transform.Translate(this.transform.position.x, this.transform.position.y, this.transform.position.z);
    }

	void Update () {
        transform.Translate(-1 * speed * Time.deltaTime, -1 * speed * Time.deltaTime, 0);

        if (transform.position.x <= endPosition && transform.position.y <= -5)
            ScrollEnd();    

        speed += 0.001f;
	}
    void ScrollEnd()
    {
        transform.Translate(-1 * (endPosition - startPosition),-1 * (endPosition - startPosition), 0);
        SendMessage("OnScrollEnd", SendMessageOptions.DontRequireReceiver);
    }
}
