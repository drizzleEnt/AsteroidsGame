using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AsteroidsPool : MonoBehaviour
{
    [SerializeField] private GameObject _container;
    [SerializeField] private int _capasity;

    private List<Asteroid> _pool = new List<Asteroid>();

    protected void Initialized(List<Asteroid> prefabs)
    {
        for (int j = 0; j < prefabs.Count; j++)
        {
            for (int i = 0; i < _capasity; i++)
            {
                Asteroid spawned = Instantiate(prefabs[j], _container.transform);
                spawned.gameObject.SetActive(false);

                _pool.Add(spawned);
            }
        }
        
    }

    protected bool TryGetObject(out Asteroid result)
    {
        result = _pool.FirstOrDefault(p => p.gameObject.activeSelf == false);

        return result != null;
    }
}
