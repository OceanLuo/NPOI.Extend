using System;

namespace NPOI.Extend
{
    /// <summary>
    /// the DrawingIgnoreAttribute class is used to represend this field will be ignored while converting the object to excel
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    [Serializable]
    public class DrawingIgnoreAttribute : Attribute
    {
    }
}