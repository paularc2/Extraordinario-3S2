using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NewCharacterPosition
{
    public Unit unit;
    public float timestamp;
    public Vector3 position;

    public NewCharacterPosition(Unit unit, float timestamp, Vector3 position)
    {
        this.unit = unit;
        this.timestamp = timestamp;
        this.position = position;
    }

    public NewCharacterPosition()
    {

    }

    public string ToCSV()
    {
        return $"{unit.unitName};{timestamp};{position.x};{position.y};{position.z}";
    }

    public override string ToString()
    {
        return $"{unit.unitName} {timestamp} {position}"; //Interpolated String
    }
}
