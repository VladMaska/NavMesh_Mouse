using UnityEngine;
using UnityEngine.AI;

public class PNav : MonoBehaviour {

    public Vector3 point;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/

    private NavMeshAgent _agent;

    /*––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––*/
    
    private void Start() =>_agent = this.gameObject.GetComponent<NavMeshAgent>();

    private void Update(){
        
        if ( !Input.GetMouseButtonDown( 0 ) ) return;
        
        // Create a ray from the camera through the mouse cursor position
        var ray = Camera.main.ScreenPointToRay( Input.mousePosition );

        // Perform the raycast
        if ( !Physics.Raycast( ray, out var hit ) ) return;
        
        point = hit.point;
        point.y = 0;
        // point.Normalize();
        
        _agent.SetDestination( point );

    }
    
}