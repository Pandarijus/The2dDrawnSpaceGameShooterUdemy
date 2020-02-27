using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("PlayerMovement")]
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float paddingX = 0.3f;
    [SerializeField] float paddingY = 0.8f;
    [Header("Projectile")]
    [SerializeField] GameObject projectile;
    [SerializeField] float velocitye = 10f;

    float xMin;
    float xMax;
    float yMin;
    float yMax;

    // Use this for initialization
    void Start()
    {
        SetUpMoveBoundaries();

    }

    private void SetUpMoveBoundaries()
    {
        Camera gameCamera = Camera.main;
        xMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + paddingX;
        xMax = gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - paddingX;
        yMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + paddingY;
        yMax = gameCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - paddingY;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetButton("Fire1"))
        {
            Shoot();
        }
    }

    private void Move()
    {
        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        var deltaY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        var newXPos = Mathf.Clamp(transform.position.x + deltaX, xMin, xMax);
        var newYPos = Mathf.Clamp(transform.position.y + deltaY, yMin, yMax);
        transform.position = new Vector2(newXPos, newYPos);
    }
    private void Shoot()
    {
        GameObject a = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
        Vector2 velo = new Vector2(0f, velocitye);
        a.GetComponent<Rigidbody2D>().velocity = velo;
        Destroy(a, 1f);

    }

}