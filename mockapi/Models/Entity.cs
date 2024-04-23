﻿//using Microsoft.Kiota.Abstractions.Serialization;

//namespace Graph.Community.MockApi.Models
//{
//  public class Entity : IAdditionalDataHolder, IParsable
//  {
//    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
//    public IDictionary<string, object> AdditionalData { get; set; }

//    /// <summary>The unique identifier for an entity. Read-only.</summary>
//#nullable enable
//    public string? Id { get; set; }
//#nullable restore

//    /// <summary>The OdataType property</summary>
//#nullable enable
//    public string? OdataType { get; set; }
//#nullable restore

//    /// <summary>
//    /// Instantiates a new <see cref="Entity"/> and sets the default values.
//    /// </summary>
//    public Entity()
//    {
//      AdditionalData = new Dictionary<string, object>();
//    }
//    /// <summary>
//    /// Creates a new instance of the appropriate class based on discriminator value
//    /// </summary>
//    /// <returns>A <see cref="Entity"/></returns>
//    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
//    public static Entity CreateFromDiscriminatorValue(IParseNode parseNode)
//    {
//      _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
//      var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
//      return mappingValue switch
//      {
//        //"#SP.Group" => new Group(),
//        //"#SP.User" => new User(),
//        //"#SP.Web" => new Web(),
//        _ => new Entity(),
//      };
//    }
//    /// <summary>
//    /// The deserialization information for the current model
//    /// </summary>
//    /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
//    public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
//    {
//      return new Dictionary<string, Action<IParseNode>>
//      {
//          {"id", n => { Id = n.GetStringValue(); } },
//          {"@odata.type", n => { OdataType = n.GetStringValue(); } },
//      };
//    }
//    /// <summary>
//    /// Serializes information the current object
//    /// </summary>
//    /// <param name="writer">Serialization writer to use to serialize this model</param>
//    public virtual void Serialize(ISerializationWriter writer)
//    {
//      _ = writer ?? throw new ArgumentNullException(nameof(writer));
//      writer.WriteStringValue("id", Id);
//      writer.WriteStringValue("@odata.type", OdataType);
//      writer.WriteAdditionalData(AdditionalData);
//    }
//  }
//}
