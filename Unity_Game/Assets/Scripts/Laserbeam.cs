using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBeam
{
    Vector2 pos, dir;
    GameObject laserObj;
    LineRenderer laser;
    List<Vector2> laserIndices = new List<Vector2>();

    public LaserBeam(Vector2 pos, Vector2 dir, Material material)
    {
        this.laser = new LineRenderer();
        this.laserObj.name = "Laser Beam";
        this.pos = pos;
        this.dir = dir;

        this.laser = this.laserObj.AddComponent(typeof(LineRenderer)) as LineRenderer;
        this.laser.startWidth = 0.1f;
        this.laser.endWidth = 0.1f;
        this.laser.material = material;
        this.laser.startColor = Color.green;
        this.laser.endColor = Color.green;
    }
}
