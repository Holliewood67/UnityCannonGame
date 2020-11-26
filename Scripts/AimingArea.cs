using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimingArea : MonoBehaviour
{
    public PlayerTarget playerTarget;
    public LaunchButton launchButton;

    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                if (raycastHit.collider.CompareTag("AimingArea"))
                {
                    playerTarget.transform.position = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                    playerTarget.transform.position = new Vector3(playerTarget.transform.position.x, playerTarget.transform.position.y, -1);

                }
            }
        }
    }

    private void OnMouseDown()
    {
        playerTarget.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        playerTarget.transform.position = new Vector3(playerTarget.transform.position.x, playerTarget.transform.position.y, -1);
        launchButton.gameObject.SetActive(true);
    }
}
