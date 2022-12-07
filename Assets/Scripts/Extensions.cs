using UnityEngine;

public static class Extensions
{
    public static bool Raycast(this Rigidbody2D rigidbody2D, Vector2 direction)
    {
        if (rigidbody2D.isKinematic) return false;
        return true;
    }
}