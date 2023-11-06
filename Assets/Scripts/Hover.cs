using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{
    //Använder detta för att justera värderna i menyn
    public Vector3 RotateSpeed = new Vector3 (10.0f, 10.0f, 10.0f);
    public Vector3 WobbleAmount = new Vector3(0.1f, 0.1f, 0.1f);
    public Vector3 WobbleSpeed = new Vector3(0.5f, 0.5f, 0.5f);

    //Värden och variablar i bakgrunden som inte visas.
    private Transform tr;
    private Vector3 BasePosition;
    private Vector3 NoiseIndex = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        // https://docs.unity3d.com/ScriptReference/GameObject.GetComponent.html
        tr = GetComponent<Transform>() as Transform;

        BasePosition = tr.position;

        NoiseIndex.x = Random.value;
        NoiseIndex.y = Random.value;
        NoiseIndex.z = Random.value;
    }

    // Update is called once per frame
    void Update()
    {
        //1. Rotationen
        // Rotate the cube by RotateSpeed, multiplied by the fraction of a second that has passed.
        // In other words, we want to rotate by the full amount over 1 second
        tr.Rotate(Time.deltaTime * RotateSpeed);

        //2. Wobble
        // Calculate how much to offset the cube from it's base position using PerlinNoise
        Vector3 offset = new Vector3();
        offset.x = Mathf.PerlinNoise(NoiseIndex.x, 0) - 0.5F;
        offset.y = Mathf.PerlinNoise(NoiseIndex.y, 0) - 0.5F;
        offset.z = Mathf.PerlinNoise(NoiseIndex.z, 0) - 0.5F;

        offset.Scale(WobbleAmount);

        // Set the position to the BasePosition plus the offset
        transform.position = BasePosition + offset;

        // Increment the NoiseIndex so that we get a new Noise value next time.
        NoiseIndex += WobbleSpeed * Time.deltaTime;
    }
}
