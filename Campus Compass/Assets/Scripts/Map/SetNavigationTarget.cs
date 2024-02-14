using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SetNavigationTarget : MonoBehaviour
{
    [SerializeField]
    private Camera topDownCamera;

    [SerializeField]
    private List<Target>  navTargetObjectList = new List<Target>();


    private NavMeshPath path; //current calculated path
    private LineRenderer line; //linerenderer to display the path
    private Vector3 targetPosition = Vector3.zero; // current target position
    

    private bool lineToggle = true;



    // Start is called before the first frame update
    private void Start()
    {
        path = new NavMeshPath();
        line = transform.GetComponent<LineRenderer>();
        line.enabled = lineToggle; 
        SetCurrentNavigationTarget();
    }
    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            lineToggle = !lineToggle;
        }
        if (lineToggle && targetPosition != Vector3.zero)
        {
            NavMesh.CalculatePath(transform.position, targetPosition, NavMesh.AllAreas, path);
            line.positionCount = path.corners.Length;
            line.SetPositions(path.corners);
            line.enabled = true;
        }
    }

    public void SetCurrentNavigationTarget()
    {
        targetPosition = Vector3.zero;
        Target currentTarget = navTargetObjectList.Find(x => x.Name.Equals(PlayerPrefs.GetString("Destination")));
        if (currentTarget != null)
        {
            targetPosition = currentTarget.PositionObject.transform.position;
            OtherTargetsInvisible(PlayerPrefs.GetString("Destination"));

        }
    }

    private void OtherTargetsInvisible( string name)
    {
        for (int i = 0;  i < navTargetObjectList.Count; i++)
        {
            if (navTargetObjectList[i].Name != name)
            {
                Renderer objectRenderer = navTargetObjectList[i].PositionObject.GetComponent<Renderer>();
                objectRenderer.enabled = false;

            }
        }
    }
    

}


