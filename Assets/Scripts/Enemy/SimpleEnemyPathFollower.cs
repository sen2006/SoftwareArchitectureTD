using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SimpleEnemyPathFollower : EnemyTargetSelector
{
    [SerializeField]LevelPath levelPath;
        int pathNodeID = 0;

    public override Vector3 GetTarget()
    {
        Vector2 target = levelPath.GetNode(pathNodeID);
        return new Vector3(target.x, transform.position.y, target.y);
    }

    public override void reachedTarget()
    {
        pathNodeID++;
        int pathLength = levelPath.GetPathLenght();
        if (pathNodeID >= pathLength)
        {
            pathNodeID = pathLength-1;
        }
    }
}
