using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;
public class PlayerController : MonoBehaviour
/*{
    public GameObject bullet;
    public float projectileForce = 100f;
    public void OnFire(InputAction.CallbackContext context)
    {
        GameObject go = Instantiate(bullet);
        go.GetComponent<Rigidbody>().AddForce(transform.forward);
    }
}*/
{
    public GameObject projectile;

    public void OnFire(InputAction.CallbackContext context)
    {
        Fire();
    }

    private void Fire()
    {
        var transform = this.transform;
        var newProjectile = Instantiate(projectile);
        newProjectile.transform.position = transform.position + transform.forward * 0.6f;
        newProjectile.transform.rotation = transform.rotation;
        const int size = 1;
        newProjectile.transform.localScale *= size;
        newProjectile.GetComponent<Rigidbody>().mass = Mathf.Pow(size, 3);
        newProjectile.GetComponent<Rigidbody>().AddForce(transform.forward * 20f, ForceMode.Impulse);
    }
}