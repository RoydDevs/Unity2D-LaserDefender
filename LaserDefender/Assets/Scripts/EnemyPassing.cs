using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyPassing : MonoBehaviour
{
    private WaveConfig waveConfig;
    private List<Transform> wayPoints;
    private int wayPointIndex = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am new enemy -> get path");
        wayPoints = waveConfig.GetWayPoints();
        transform.position = wayPoints[wayPointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void SetWaveConfig(WaveConfig waveConfig)
    {
        this.waveConfig = waveConfig;
    }

    private void Move()
    {
        if (wayPointIndex <= wayPoints.Count - 1)
        {
            var targetPosition = wayPoints[wayPointIndex].transform.position;
            var movementThisFrame = waveConfig.GetMoveSpeed() * Time.deltaTime;
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
