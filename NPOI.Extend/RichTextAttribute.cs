using System;

namespace NPOI.Extend
{
    /// <summary>
    /// indicate that this property is the rich text string
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    [Serializable]
    public class RichTextAttribute : Attribute
    {
    }
}
