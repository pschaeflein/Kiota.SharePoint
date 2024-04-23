﻿using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;

namespace Graph.Community
{
  public class ODataError : ApiException, IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>The error property</summary>

#nullable enable
        public MainError? Error { get; set; }
#nullable restore

        /// <summary>The primary error message.</summary>
        public override string Message { get => Error?.Message ?? string.Empty; }

        /// <summary>
        /// Instantiates a new <see cref="ODataError"/> and sets the default values.
        /// </summary>
        public ODataError()
        {
            AdditionalData = new Dictionary<string, object>();
        }

        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ODataError"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ODataError CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ODataError();
        }

        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
          return new Dictionary<string, Action<IParseNode>>
          {
            {"error", n => { Error = n.GetObjectValue(MainError.CreateFromDiscriminatorValue); } },
          };
        }

        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue("error", Error);
            writer.WriteAdditionalData(AdditionalData);
        }
    }



}