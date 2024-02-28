using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 3f;
    [SerializeField] private float _spawnHeight = 1f;

    [SerializeField] private GameObject _pipe;

    private float _timer;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }


    void Update()
    {
        if (_timer > _maxTime)
        {
            SpawnPipe();
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 spawnpos = transform.position + new Vector3(0, Random.Range(-_spawnHeight, _spawnHeight));
        GameObject pipe = Instantiate(_pipe, spawnpos, Quaternion.identity);

        Destroy(pipe, 10f);
    }
}
