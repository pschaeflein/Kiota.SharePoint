// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Graph.Community.Models {
    public class RegionalSettings : IParsable 
    {
        /// <summary>The AdjustHijriDays property</summary>
        public int? AdjustHijriDays { get; set; }
        /// <summary>The AlternateCalendarType property</summary>
        public int? AlternateCalendarType { get; set; }
        /// <summary>The AM property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AM { get; set; }
#nullable restore
#else
        public string AM { get; set; }
#endif
        /// <summary>The CalendarType property</summary>
        public int? CalendarType { get; set; }
        /// <summary>The Collation property</summary>
        public int? Collation { get; set; }
        /// <summary>The CollationLCID property</summary>
        public int? CollationLCID { get; set; }
        /// <summary>The DateFormat property</summary>
        public int? DateFormat { get; set; }
        /// <summary>The DateSeparator property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DateSeparator { get; set; }
#nullable restore
#else
        public string DateSeparator { get; set; }
#endif
        /// <summary>The DecimalSeparator property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DecimalSeparator { get; set; }
#nullable restore
#else
        public string DecimalSeparator { get; set; }
#endif
        /// <summary>The DigitGrouping property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DigitGrouping { get; set; }
#nullable restore
#else
        public string DigitGrouping { get; set; }
#endif
        /// <summary>The FirstDayOfWeek property</summary>
        public int? FirstDayOfWeek { get; set; }
        /// <summary>The FirstWeekOfYear property</summary>
        public int? FirstWeekOfYear { get; set; }
        /// <summary>The IsEastAsia property</summary>
        public bool? IsEastAsia { get; set; }
        /// <summary>The IsRightToLeft property</summary>
        public bool? IsRightToLeft { get; set; }
        /// <summary>The IsUIRightToLeft property</summary>
        public bool? IsUIRightToLeft { get; set; }
        /// <summary>The ListSeparator property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ListSeparator { get; set; }
#nullable restore
#else
        public string ListSeparator { get; set; }
#endif
        /// <summary>The LocaleId property</summary>
        public int? LocaleId { get; set; }
        /// <summary>The NegativeSign property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NegativeSign { get; set; }
#nullable restore
#else
        public string NegativeSign { get; set; }
#endif
        /// <summary>The NegNumberMode property</summary>
        public int? NegNumberMode { get; set; }
        /// <summary>The PM property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PM { get; set; }
#nullable restore
#else
        public string PM { get; set; }
#endif
        /// <summary>The PositiveSign property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PositiveSign { get; set; }
#nullable restore
#else
        public string PositiveSign { get; set; }
#endif
        /// <summary>The ShowWeeks property</summary>
        public bool? ShowWeeks { get; set; }
        /// <summary>The ThousandSeparator property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThousandSeparator { get; set; }
#nullable restore
#else
        public string ThousandSeparator { get; set; }
#endif
        /// <summary>The Time24 property</summary>
        public bool? Time24 { get; set; }
        /// <summary>The TimeMarkerPosition property</summary>
        public int? TimeMarkerPosition { get; set; }
        /// <summary>The TimeSeparator property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeSeparator { get; set; }
#nullable restore
#else
        public string TimeSeparator { get; set; }
#endif
        /// <summary>The TimeZone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TimeZoneObject? TimeZone { get; set; }
#nullable restore
#else
        public TimeZoneObject TimeZone { get; set; }
#endif
        /// <summary>The WorkDayEndHour property</summary>
        public int? WorkDayEndHour { get; set; }
        /// <summary>The WorkDays property</summary>
        public int? WorkDays { get; set; }
        /// <summary>The WorkDayStartHour property</summary>
        public int? WorkDayStartHour { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RegionalSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RegionalSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RegionalSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"AM", n => { AM = n.GetStringValue(); } },
                {"AdjustHijriDays", n => { AdjustHijriDays = n.GetIntValue(); } },
                {"AlternateCalendarType", n => { AlternateCalendarType = n.GetIntValue(); } },
                {"CalendarType ", n => { CalendarType = n.GetIntValue(); } },
                {"Collation", n => { Collation = n.GetIntValue(); } },
                {"CollationLCID", n => { CollationLCID = n.GetIntValue(); } },
                {"DateFormat", n => { DateFormat = n.GetIntValue(); } },
                {"DateSeparator", n => { DateSeparator = n.GetStringValue(); } },
                {"DecimalSeparator", n => { DecimalSeparator = n.GetStringValue(); } },
                {"DigitGrouping", n => { DigitGrouping = n.GetStringValue(); } },
                {"FirstDayOfWeek", n => { FirstDayOfWeek = n.GetIntValue(); } },
                {"FirstWeekOfYear", n => { FirstWeekOfYear = n.GetIntValue(); } },
                {"IsEastAsia", n => { IsEastAsia = n.GetBoolValue(); } },
                {"IsRightToLeft", n => { IsRightToLeft = n.GetBoolValue(); } },
                {"IsUIRightToLeft", n => { IsUIRightToLeft = n.GetBoolValue(); } },
                {"ListSeparator", n => { ListSeparator = n.GetStringValue(); } },
                {"LocaleId", n => { LocaleId = n.GetIntValue(); } },
                {"NegNumberMode", n => { NegNumberMode = n.GetIntValue(); } },
                {"NegativeSign", n => { NegativeSign = n.GetStringValue(); } },
                {"PM", n => { PM = n.GetStringValue(); } },
                {"PositiveSign", n => { PositiveSign = n.GetStringValue(); } },
                {"ShowWeeks", n => { ShowWeeks = n.GetBoolValue(); } },
                {"ThousandSeparator", n => { ThousandSeparator = n.GetStringValue(); } },
                {"Time24", n => { Time24 = n.GetBoolValue(); } },
                {"TimeMarkerPosition", n => { TimeMarkerPosition = n.GetIntValue(); } },
                {"TimeSeparator", n => { TimeSeparator = n.GetStringValue(); } },
                {"TimeZone", n => { TimeZone = n.GetObjectValue<TimeZoneObject>(TimeZoneObject.CreateFromDiscriminatorValue); } },
                {"WorkDayEndHour", n => { WorkDayEndHour = n.GetIntValue(); } },
                {"WorkDayStartHour", n => { WorkDayStartHour = n.GetIntValue(); } },
                {"WorkDays", n => { WorkDays = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("AdjustHijriDays", AdjustHijriDays);
            writer.WriteIntValue("AlternateCalendarType", AlternateCalendarType);
            writer.WriteStringValue("AM", AM);
            writer.WriteIntValue("CalendarType ", CalendarType);
            writer.WriteIntValue("Collation", Collation);
            writer.WriteIntValue("CollationLCID", CollationLCID);
            writer.WriteIntValue("DateFormat", DateFormat);
            writer.WriteStringValue("DateSeparator", DateSeparator);
            writer.WriteStringValue("DecimalSeparator", DecimalSeparator);
            writer.WriteStringValue("DigitGrouping", DigitGrouping);
            writer.WriteIntValue("FirstDayOfWeek", FirstDayOfWeek);
            writer.WriteIntValue("FirstWeekOfYear", FirstWeekOfYear);
            writer.WriteBoolValue("IsEastAsia", IsEastAsia);
            writer.WriteBoolValue("IsRightToLeft", IsRightToLeft);
            writer.WriteBoolValue("IsUIRightToLeft", IsUIRightToLeft);
            writer.WriteStringValue("ListSeparator", ListSeparator);
            writer.WriteIntValue("LocaleId", LocaleId);
            writer.WriteStringValue("NegativeSign", NegativeSign);
            writer.WriteIntValue("NegNumberMode", NegNumberMode);
            writer.WriteStringValue("PM", PM);
            writer.WriteStringValue("PositiveSign", PositiveSign);
            writer.WriteBoolValue("ShowWeeks", ShowWeeks);
            writer.WriteStringValue("ThousandSeparator", ThousandSeparator);
            writer.WriteBoolValue("Time24", Time24);
            writer.WriteIntValue("TimeMarkerPosition", TimeMarkerPosition);
            writer.WriteStringValue("TimeSeparator", TimeSeparator);
            writer.WriteObjectValue<TimeZoneObject>("TimeZone", TimeZone);
            writer.WriteIntValue("WorkDayEndHour", WorkDayEndHour);
            writer.WriteIntValue("WorkDays", WorkDays);
            writer.WriteIntValue("WorkDayStartHour", WorkDayStartHour);
        }
    }
}