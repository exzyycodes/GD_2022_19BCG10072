using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulpit: MonoBehaviour
{
    #region Variables
    // death support
    const float EnemyLifespanSeconds = 10;
    Timer deathTimer;

    #endregion
    void Start()
    {
        deathTimer = gameObject.AddComponent<Timer>();
        deathTimer.Duration = EnemyLifespanSeconds;
        deathTimer.Run();
    }

    void Update()
    {
        if (deathTimer)
        {
            if (deathTimer.Finished)
            {
                Destroy(Object);
            }
        }

    }

}