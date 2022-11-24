using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private float _spawnOffset;
    [SerializeField] private List<GameObject> _unitTypes;
    [SerializeField] private int _unitType;
    [SerializeField] private int _unitQuantity;

    private void Start()
    {
        _spawnPosition.position = new Vector3(_spawnPosition.position.x, _spawnPosition.position.y, _spawnPosition.position.z);
        SpawnUnits(_unitType, _unitQuantity);
       
    }

    private void SpawnUnits(int unitType, int unitQuantity)
    {
        for (int i = 0; i < unitQuantity/2; i++)
        {
            Instantiate(_unitTypes[unitType], _spawnPosition.position, Quaternion.identity);
            for (int j = 1; j <=1; j++)
            {
                _spawnPosition.position = new Vector3(_spawnPosition.position.x, _spawnPosition.position.y, _spawnPosition.position.z + _spawnOffset);
                Instantiate(_unitTypes[unitType], _spawnPosition.position, Quaternion.identity);
                _spawnPosition.position = new Vector3(_spawnPosition.position.x, _spawnPosition.position.y, _spawnPosition.position.z - _spawnOffset);

            }
            _spawnPosition.position = new Vector3(_spawnPosition.position.x + _spawnOffset, _spawnPosition.position.y, _spawnPosition.position.z);
        }
        
    }
}
