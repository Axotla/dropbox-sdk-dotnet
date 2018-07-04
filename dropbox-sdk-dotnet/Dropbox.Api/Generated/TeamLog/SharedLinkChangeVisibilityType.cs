// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The shared link change visibility type object</para>
    /// </summary>
    public class SharedLinkChangeVisibilityType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedLinkChangeVisibilityType> Encoder = new SharedLinkChangeVisibilityTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedLinkChangeVisibilityType> Decoder = new SharedLinkChangeVisibilityTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedLinkChangeVisibilityType"
        /// /> class.</para>
        /// </summary>
        /// <param name="description">The description</param>
        public SharedLinkChangeVisibilityType(string description)
        {
            if (description == null)
            {
                throw new sys.ArgumentNullException("description");
            }

            this.Description = description;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedLinkChangeVisibilityType"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedLinkChangeVisibilityType()
        {
        }

        /// <summary>
        /// <para>Gets the description of the shared link change visibility type</para>
        /// </summary>
        public string Description { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedLinkChangeVisibilityType" />.</para>
        /// </summary>
        private class SharedLinkChangeVisibilityTypeEncoder : enc.StructEncoder<SharedLinkChangeVisibilityType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedLinkChangeVisibilityType value, enc.IJsonWriter writer)
            {
                WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedLinkChangeVisibilityType" />.</para>
        /// </summary>
        private class SharedLinkChangeVisibilityTypeDecoder : enc.StructDecoder<SharedLinkChangeVisibilityType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharedLinkChangeVisibilityType"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedLinkChangeVisibilityType Create()
            {
                return new SharedLinkChangeVisibilityType();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedLinkChangeVisibilityType value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "description":
                        value.Description = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}