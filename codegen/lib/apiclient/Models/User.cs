// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Graph.Community.Models
{
    #pragma warning disable CS1591
    public class User : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The Email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The IsEmailAuthenticationGuestUser property</summary>
        public bool? IsEmailAuthenticationGuestUser { get; set; }
        /// <summary>The isHiddenInUI property</summary>
        public bool? IsHiddenInUI { get; set; }
        /// <summary>The IsShareByEmailGuestUser property</summary>
        public bool? IsShareByEmailGuestUser { get; set; }
        /// <summary>The IsSiteAdmin property</summary>
        public bool? IsSiteAdmin { get; set; }
        /// <summary>The loginName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LoginName { get; set; }
#nullable restore
#else
        public string LoginName { get; set; }
#endif
        /// <summary>The principalType property</summary>
        public int? PrincipalType { get; set; }
        /// <summary>The title property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>The UserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Graph.Community.Models.UserId? UserId { get; set; }
#nullable restore
#else
        public Graph.Community.Models.UserId UserId { get; set; }
#endif
        /// <summary>The UserPrincipalName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName { get; set; }
#nullable restore
#else
        public string UserPrincipalName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Graph.Community.Models.User"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Graph.Community.Models.User CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Graph.Community.Models.User();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "Email", n => { Email = n.GetStringValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "IsEmailAuthenticationGuestUser", n => { IsEmailAuthenticationGuestUser = n.GetBoolValue(); } },
                { "isHiddenInUI", n => { IsHiddenInUI = n.GetBoolValue(); } },
                { "IsShareByEmailGuestUser", n => { IsShareByEmailGuestUser = n.GetBoolValue(); } },
                { "IsSiteAdmin", n => { IsSiteAdmin = n.GetBoolValue(); } },
                { "loginName", n => { LoginName = n.GetStringValue(); } },
                { "principalType", n => { PrincipalType = n.GetIntValue(); } },
                { "title", n => { Title = n.GetStringValue(); } },
                { "UserId", n => { UserId = n.GetObjectValue<Graph.Community.Models.UserId>(Graph.Community.Models.UserId.CreateFromDiscriminatorValue); } },
                { "UserPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("Email", Email);
            writer.WriteIntValue("id", Id);
            writer.WriteBoolValue("IsEmailAuthenticationGuestUser", IsEmailAuthenticationGuestUser);
            writer.WriteBoolValue("isHiddenInUI", IsHiddenInUI);
            writer.WriteBoolValue("IsShareByEmailGuestUser", IsShareByEmailGuestUser);
            writer.WriteBoolValue("IsSiteAdmin", IsSiteAdmin);
            writer.WriteStringValue("loginName", LoginName);
            writer.WriteIntValue("principalType", PrincipalType);
            writer.WriteStringValue("title", Title);
            writer.WriteObjectValue<Graph.Community.Models.UserId>("UserId", UserId);
            writer.WriteStringValue("UserPrincipalName", UserPrincipalName);
        }
    }
}
