/* 
 * Influx API Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 0.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = InfluxDB.Client.Api.Client.OpenAPIDateConverter;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// HistogramViewProperties
    /// </summary>
    [DataContract]
    public partial class HistogramViewProperties : ViewProperties,  IEquatable<HistogramViewProperties>
    {
        /// <summary>
        /// Defines Shape
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShapeEnum
        {
            /// <summary>
            /// Enum ChronografV2 for value: chronograf-v2
            /// </summary>
            [EnumMember(Value = "chronograf-v2")]
            ChronografV2 = 1

        }

        /// <summary>
        /// Gets or Sets Shape
        /// </summary>
        [DataMember(Name="shape", EmitDefaultValue=false)]
        public ShapeEnum? Shape { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Histogram for value: histogram
            /// </summary>
            [EnumMember(Value = "histogram")]
            Histogram = 1

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HistogramViewProperties" /> class.
        /// </summary>
        /// <param name="shape">shape.</param>
        /// <param name="type">type.</param>
        /// <param name="xColumn">xColumn.</param>
        /// <param name="fillColumns">fillColumns.</param>
        /// <param name="xDomain">xDomain.</param>
        /// <param name="xAxisLabel">xAxisLabel.</param>
        /// <param name="position">position.</param>
        /// <param name="binCount">binCount.</param>
        public HistogramViewProperties(ShapeEnum? shape = default(ShapeEnum?), TypeEnum? type = default(TypeEnum?), string xColumn = default(string), List<string> fillColumns = default(List<string>), List<float?> xDomain = default(List<float?>), string xAxisLabel = default(string), string position = default(string), int? binCount = default(int?), List<DashboardQuery> queries = default(List<DashboardQuery>), List<DashboardColor> colors = default(List<DashboardColor>), string note = default(string), bool? showNoteWhenEmpty = default(bool?)) : base(queries, colors, note, showNoteWhenEmpty)
        {
            this.Shape = shape;
            this.Type = type;
            this.XColumn = xColumn;
            this.FillColumns = fillColumns;
            this.XDomain = xDomain;
            this.XAxisLabel = xAxisLabel;
            this.Position = position;
            this.BinCount = binCount;
        }



        /// <summary>
        /// Gets or Sets XColumn
        /// </summary>
        [DataMember(Name="xColumn", EmitDefaultValue=false)]
        public string XColumn { get; set; }

        /// <summary>
        /// Gets or Sets FillColumns
        /// </summary>
        [DataMember(Name="fillColumns", EmitDefaultValue=false)]
        public List<string> FillColumns { get; set; }

        /// <summary>
        /// Gets or Sets XDomain
        /// </summary>
        [DataMember(Name="xDomain", EmitDefaultValue=false)]
        public List<float?> XDomain { get; set; }

        /// <summary>
        /// Gets or Sets XAxisLabel
        /// </summary>
        [DataMember(Name="xAxisLabel", EmitDefaultValue=false)]
        public string XAxisLabel { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public string Position { get; set; }

        /// <summary>
        /// Gets or Sets BinCount
        /// </summary>
        [DataMember(Name="binCount", EmitDefaultValue=false)]
        public int? BinCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistogramViewProperties {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Shape: ").Append(Shape).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  XColumn: ").Append(XColumn).Append("\n");
            sb.Append("  FillColumns: ").Append(FillColumns).Append("\n");
            sb.Append("  XDomain: ").Append(XDomain).Append("\n");
            sb.Append("  XAxisLabel: ").Append(XAxisLabel).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  BinCount: ").Append(BinCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as HistogramViewProperties);
        }

        /// <summary>
        /// Returns true if HistogramViewProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of HistogramViewProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistogramViewProperties input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Shape == input.Shape ||
                    (this.Shape != null &&
                    this.Shape.Equals(input.Shape))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.XColumn == input.XColumn ||
                    (this.XColumn != null &&
                    this.XColumn.Equals(input.XColumn))
                ) && base.Equals(input) && 
                (
                    this.FillColumns == input.FillColumns ||
                    this.FillColumns != null &&
                    this.FillColumns.SequenceEqual(input.FillColumns)
                ) && base.Equals(input) && 
                (
                    this.XDomain == input.XDomain ||
                    this.XDomain != null &&
                    this.XDomain.SequenceEqual(input.XDomain)
                ) && base.Equals(input) && 
                (
                    this.XAxisLabel == input.XAxisLabel ||
                    (this.XAxisLabel != null &&
                    this.XAxisLabel.Equals(input.XAxisLabel))
                ) && base.Equals(input) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && base.Equals(input) && 
                (
                    this.BinCount == input.BinCount ||
                    (this.BinCount != null &&
                    this.BinCount.Equals(input.BinCount))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Shape != null)
                    hashCode = hashCode * 59 + this.Shape.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.XColumn != null)
                    hashCode = hashCode * 59 + this.XColumn.GetHashCode();
                if (this.FillColumns != null)
                    hashCode = hashCode * 59 + this.FillColumns.GetHashCode();
                if (this.XDomain != null)
                    hashCode = hashCode * 59 + this.XDomain.GetHashCode();
                if (this.XAxisLabel != null)
                    hashCode = hashCode * 59 + this.XAxisLabel.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.BinCount != null)
                    hashCode = hashCode * 59 + this.BinCount.GetHashCode();
                return hashCode;
            }
        }

    }

}
