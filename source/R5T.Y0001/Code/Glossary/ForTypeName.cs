using System;


namespace R5T.Y0001
{
    public static partial class Glossary
    {
        // Use nested class to avoid namespace name-to-class name collision.
        // Use 'For' prefix to avoid problems with members having the same name as their enclosing types.
        public static class ForTypeName
        {
            /// <summary>
            /// <inheritdoc cref="FullTypeName" path="/definition"/>
            /// </summary>
            /// <definition>The full type name is any and all information about a type, including at least the <inheritdoc cref="NamespacedTypeName" path="/name"/>, but might also include assembly, array, generic, or other information.</definition>
            /// <name><i>full type name</i></name>
            public static readonly object FullTypeName;

            /// <summary>
            /// <inheritdoc cref="NamespacedTypeName" path="/definition"/>
            /// </summary>
            /// <definition>The namespaced type name is the <inheritdoc cref="ForNamespaceName.NamespaceName" path="/name"/> combined with the <inheritdoc cref="TypeName" path="/name"/>.</definition>
            /// <name><i>namespaced type name</i></name>
            public static readonly object NamespacedTypeName;

            /// <summary>
            /// <inheritdoc cref="TypeName" path="/definition"/>
            /// </summary>
            /// <definition>The type name is just the name of the type.</definition>
            /// <name><i>type name</i></name>
            public static readonly object TypeName;
        }
    }
}
