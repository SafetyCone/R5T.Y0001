using System;


namespace R5T.Y0001
{
    public static partial class Glossary
    {
        // Use nested class to avoid namespace name-to-class name collision.
        // Use 'For' prefix to avoid problems with members having the same name as their enclosing types.
        public static class ForNamespaceName
        {
            /// <summary>
            /// <inheritdoc cref="FullNamespaceName" path="/definition"/>
            /// <para>The <inheritdoc cref="FullNamespaceName" path="/name"/> is just the <inheritdoc cref="NamespaceName" path="/name"/>.</para>
            /// </summary>
            /// <definition>The full namespace name is the complete (not partial or fragmented) namespace name including all the <inheritdoc cref="NamespaceNameToken" path="/name"/>s from the <inheritdoc cref="NamespaceNameRoot" path="/name"/> to the <inheritdoc cref="NamespaceNameLeaf" path="/name"/>.</definition>
            /// <name><i>full namespace name</i></name>
            public static readonly object FullNamespaceName;

            /// <summary>
            /// <inheritdoc cref="NamespaceName" path="/definition"/>
            /// <para>The <inheritdoc cref="NamespaceName" path="/name"/> is just the <inheritdoc cref="FullNamespaceName" path="/name"/>, and is composed of <inheritdoc cref="NamespaceNameToken" path="/name"/>s separated by , and is composed of <inheritdoc cref="NamespaceNameTokenSeparator" path="/name"/>s.</para>
            /// </summary>
            /// <definition>The namespace name is the full (not partial or fragmented) namespace name.</definition>
            /// <name><i>namespace name</i></name>
            public static readonly object NamespaceName;

            /// <summary>
            /// <inheritdoc cref="NamespaceNameFragment" path="/definition"/>
            /// </summary>
            /// <definition>A namespace name fragment is a piece of a <inheritdoc cref="NamespaceName" path="/name"/>, generally *not* including the <inheritdoc cref="NamespaceNameRoot" path="/name"/> or the <inheritdoc cref="NamespaceNameLeaf" path="/name"/> (unlike a <inheritdoc cref="PartialNamespaceName" path="/name"/>).</definition>
            /// <name><i>namespace name fragment</i></name>
            public static readonly object NamespaceNameFragment;

            /// <summary>
            /// <inheritdoc cref="NamespaceNameLeaf" path="/definition"/>
            /// </summary>
            /// <definition>The namespace name leaf is the ending of the <inheritdoc cref="NamespaceName" path="/name"/>.</definition>
            /// <name><i>namespace name leaf</i></name>
            public static readonly object NamespaceNameLeaf;

            /// <summary>
            /// <inheritdoc cref="NamespaceNameRoot" path="/definition"/>
            /// </summary>
            /// <definition>The namespace name root is the beginning of the <inheritdoc cref="NamespaceName" path="/name"/>.</definition>
            /// <name><i>namespace name root</i></name>
            public static readonly object NamespaceNameRoot;

            /// <summary>
            /// <inheritdoc cref="NamespaceNameToken" path="/name"/> <inheritdoc cref="NamespaceNameToken" path="/definition"/>
            /// A <inheritdoc cref="NamespaceName" path="/name"/> is made of namespace name tokens.
            /// </summary>
            /// <definition>A <inheritdoc cref="NamespaceNameToken" path="/name"/> is the string separated by either <inheritdoc cref="NamespaceNameTokenSeparator" path="/name"/>s, the beginning, or the end of the <inheritdoc cref="NamespaceName" path="/name"/>.</definition>
            /// <name><i>namespace name token</i></name>
            public static readonly object NamespaceNameToken;

            /// <summary>
            /// <inheritdoc cref="NamespaceNameTokenSeparator" path="/definition"/>
            /// </summary>
            /// <definition>The namespace name token separator is '.' (period).</definition>
            /// <name><i>namespace name token separator</i></name>
            public static readonly object NamespaceNameTokenSeparator;

            /// <summary>
            /// <inheritdoc cref="PartialNamespaceName" path="/definition"/>
            /// </summary>
            /// <definition>A partial namespace name is a section (not the whole) of a <inheritdoc cref="NamespaceName" path="/name"/>, generally including the <inheritdoc cref="NamespaceNameRoot" path="/name"/> or the <inheritdoc cref="NamespaceNameLeaf" path="/name"/> (unlike a <inheritdoc cref="NamespaceNameFragment" path="/name"/>).</definition>
            /// <name><i>partial namespace name</i></name>
            public static readonly object PartialNamespaceName;
        }
    }
}
