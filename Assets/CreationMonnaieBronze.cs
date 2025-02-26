using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationMonnaieBronze : MonoBehaviour
{
    [SerializeField] GameObject _prefabMonnaieBronze;
    [SerializeField] Vector3 _position;
    
    // Start is called before the first frame update
    void Start()
    {
        Quaternion _rotation = Quaternion.Euler(0, 90f, 0);
        int i = 0;

        while(i<= 10)
        {
            Instantiate(_prefabMonnaieBronze,_position, _rotation);
            i++;
        }
        
        
    }

}
