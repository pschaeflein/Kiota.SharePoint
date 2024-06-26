// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Graph.Community.Models
{
    #pragma warning disable CS1591
    public class TimeZoneObject : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The Description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The Id property</summary>
        public int? Id { get; set; }
        /// <summary>The TimeZoneInformation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Graph.Community.Models.TimeZoneInformation? TimeZoneInformation { get; set; }
#nullable restore
#else
        public Graph.Community.Models.TimeZoneInformation TimeZoneInformation { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Graph.Community.Models.TimeZoneObject"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Graph.Community.Models.TimeZoneObject CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Graph.Community.Models.TimeZoneObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Description", n => { Description = n.GetStringValue(); } },
                { "Id", n => { Id = n.GetIntValue(); } },
                { "TimeZoneInformation", n => { TimeZoneInformation = n.GetObjectValue<Graph.Community.Models.TimeZoneInformation>(Graph.Community.Models.TimeZoneInformation.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Description", Description);
            writer.WriteIntValue("Id", Id);
            writer.WriteObjectValue<Graph.Community.Models.TimeZoneInformation>("TimeZoneInformation", TimeZoneInformation);
        }
    }
}
