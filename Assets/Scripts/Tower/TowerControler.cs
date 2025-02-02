using UnityEngine;

[RequireComponent(typeof(TowerTargetSelector))]
public class TowerControler : MonoBehaviour
{
    TowerTargetSelector targetSelector;

    [SerializeField] int range = 10;

    // Start is called before the first frame update
    void Start()
    {
        targetSelector = GetComponent<TowerTargetSelector>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject target = targetSelector.GetTarget(range);
        if (target != null)
        {
            Debug.DrawLine(transform.position + Vector3.up, target.transform.position + Vector3.up, Color.magenta);
        }
    }
}
