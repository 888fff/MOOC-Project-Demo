using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class Health : NetworkBehaviour
{
    private static int hp_max = 100;
    public int hp = hp_max;
    public bool isEnemy = false;
    public void GetDamage(int dmg)
    {
        if (!isServer)
        {
            return;
        }

        hp -= dmg;
        if (hp < 0)
        {
            if (isEnemy)
                Destroy(gameObject);
            else
                RpcRespawn();
        }
    }
    [ClientRpc]
    public void RpcRespawn()
    {
        if (isLocalPlayer)
        {
            transform.position = Vector3.zero;
            hp = hp_max;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
