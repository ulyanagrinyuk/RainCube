using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private Transform _conteiten;
    [SerializeField] private Cube _prefabCube;

    private Cube _tempCube;
    private Queue<Cube> _poolCubes = new Queue<Cube>();

    public Cube GetCube()
    {
        if (_poolCubes.Count == 0)
        {
            Debug.Log(_poolCubes.Count);
            _tempCube = Instantiate(_prefabCube, _conteiten);
        }
        else
        {
            _tempCube = _poolCubes.Dequeue();
            // _tempCube.gameObject.SetActive(true);
        }

        return _tempCube;
    }

    public void PutCube(Cube cube)
    {
        // _tempCube.gameObject.SetActive(false);
        _poolCubes.Enqueue(cube);
    }


}
