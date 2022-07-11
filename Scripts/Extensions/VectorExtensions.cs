using System;
using UnityEngine;

namespace KirisakiTechnologies.GameSystem.Scripts.Extensions
{
    public static class VectorExtensions
    {
        public static bool Approximately(Vector3 a, Vector3 b)
        {
            return Mathf.Approximately(a.x, b.x) && Mathf.Approximately(a.y, b.y) && Mathf.Approximately(a.z, b.z);
        }

        public static bool IsZero(this Vector3 self)
        {
            return Approximately(self, Vector3.zero);
        }
    }
}