using System;

using R5T.T0143;


namespace R5T.T0244
{
    /// <summary>
    /// Attribute indicating an interface type is a check type.
    /// Check interfaces should be empty, consisting of just a name, but inheriting from one or more other check interfaces if they are a compound check.
    /// Check interfaces participate with R5T.L0091.T000.IChecked&gt;TCheck&lt; to allow methods to communicate their requirements and/or work performed
    /// (via out IChecked&lt;TCheck&gt;) parameters.
    /// </summary>
    /// <remarks>
    /// The marker attribute is useful for surveying assemblies and code, then building a catalogue of check types.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class CheckMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        /// <summary>
        /// Allows specifying that a type is *not* a check type.
        /// This is useful for marking types that end up canonical check type code file locations, but are not actually check types.
        /// </summary>
        public bool IsCheck { get; }


        public CheckMarkerAttribute(
            bool isCheck = true)
        {
            this.IsCheck = isCheck;
        }
    }
}
