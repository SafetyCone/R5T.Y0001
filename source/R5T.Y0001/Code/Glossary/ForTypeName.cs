using System;

using R5T.T0156;


namespace R5T.Y0001
{
    public static partial class Glossary
    {
        // Use nested class to avoid namespace name-to-class name collision.
        // Use 'For' prefix to avoid problems with members having the same name as their enclosing types.
        [DocumentationMarker]
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

            /// <summary>
            /// <inheritdoc cref="TypeNameAffix" path="/definition"/>
            /// </summary>
            /// <definition>A type name affix is either a prefix or suffix added to a type name, like the interface prefix 'I-' or the attribute suffix '-Attribute'. An affix might be composed of multiple <inheritdoc cref="TypeNameToken" path="/name"/>s.</definition>
            /// <name><i>type name affix</i></name>
            public static readonly object TypeNameAffix;

            /// <summary>
            /// <para><inheritdoc cref="TypeNameFragment" path="/definition"/></para>
            /// <para>For example: <inheritdoc cref="TypeNameFragment" path="/example"/>.</para>
            /// </summary>
            /// <definition>A type name fragment includes at least the ending <inheritdoc cref="TypeName" path="/name"/>, but may or may not include some fraction of the <inheritdoc cref="ForNamespaceName.NamespaceName" path="/name"/>.</definition>
            /// <example>"Threading.Thread" instead of the <inheritdoc cref="NamespacedTypeName" path="/name"/> "System.Threading.Thread"</example>
            /// <name><i>type name fragment</i></name>
            public static readonly object TypeNameFragment;

            /// <summary>
            /// <para><inheritdoc cref="TypeNameToken" path="/definition"/></para>
            /// <para>For example: <inheritdoc cref="TypeNameToken" path="/example"/>.</para>
            /// </summary>
            /// <definition>A type name token is a <inheritdoc cref="Y0000.Glossary.ForToken.Token" path="/name"/> of a <inheritdoc cref="TypeName" path="/name"/> that can be separated from the rest of the type name using a <inheritdoc cref="Y0000.Glossary.ForToken.TokenSeparator" path="/name"/>.</definition>
            /// <example>"Internal" in "DataSet_Internal"</example>
            /// <name><i>type name token</i></name>
            public static readonly object TypeNameToken;

            /// <summary>
            /// <para><inheritdoc cref="TypeParameterArityGenericTypeName" path="/definition"/></para>
            /// <para>Examples:</para>
            /// <inheritdoc cref="TypeParameterArityGenericTypeName" path="/examples"/>
            /// </summary>
            /// <definition>A generic type name can come in multiple forms. The type-parameter-arity form is used by .NET to uniquely describe types and is the type name, followed by tick (`), followed by the type parameter arity of the type.</definition>
            /// <examples>
            /// <para>List&lt;T&gt; => System.Collections.Generic.List`1</para>
            /// <para>List&lt;string&gt; => System.Collections.Generic.List`1</para>
            /// <para>Dictionary&lt;TKey, TValue&gt; => System.Collections.Generic.Dictionary`2</para>
            /// </examples>
            /// <name><i>type parameter arity generic type name</i></name>
            public static readonly object TypeParameterArityGenericTypeName;
        }
    }
}
