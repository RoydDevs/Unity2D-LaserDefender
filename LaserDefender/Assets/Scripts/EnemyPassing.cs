using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyPassing : MonoBehaviour
{
    [SerializeField] private List<Transform> wayPoints;
    [SerializeField] private float moveSpeed = 2f;
    private int wayPointIndex = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = wayPoints[wayPointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (wayPointIndex <= wayPoints.Count - 1)
        {
            var targetPosition = wayPoints[wayPointIndex].transform.position;
            var movementThisFrame = moveSpeed * Time.deltaTime;
            this.transform.position = Vector3.MoveTowards(this.transform.position, targetPosition, movementThisFrame);

            if (this.transform.position == targetPosition)
            {
                wayPointIndex++;
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
