using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class EnemySpawner : NetworkBehaviour
{
    public GameObject enemyPrefab;
    public int enemyNum = 5;

    public override void OnStartServer()
    {
        for (int i = 0;i< enemyNum;++i)
        {
            var unit_pos = Random.insideUnitCircle;
            unit_pos = unit_pos * 6;
            var rnd_rot = Quaternion.Euler(new Vector3(0, Random.Range(-180, 180), 0));
            var enemy = Instantiate(enemyPrefab,new Vector3(unit_pos.x, 0 ,unit_pos.y), rnd_rot);
            NetworkServer.Spawn(enemy);
        }
    }
}
