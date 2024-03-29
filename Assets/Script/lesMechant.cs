using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lesMechant : MonoBehaviour
{
    public float speed;
    public Transform[] waypoint;

    private Transform target;
    private int destPoint = 0;

    void Start()
    {
        target = waypoint[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if(Vector3.Distance(transform.position, target.position) < 0.3f)
        {
            destPoint = (destPoint + 1) % waypoint.Length;
            target = waypoint[destPoint];

            // Inverser l'échelle sur l'axe x pour faire face à la nouvelle direction
            Flip();
        }
    }

    void Flip()
    {
        Vector3 newScale = transform.localScale;
        newScale.x *= -1;
        transform.localScale = newScale;
    }
}
