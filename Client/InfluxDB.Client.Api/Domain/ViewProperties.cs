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
    /// ViewProperties
    /// </summary>
    [DataContract]
    public partial class ViewProperties :  IEquatable<ViewProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewProperties" /> class.
        /// </summary>
        /// <param name="queries">queries.</param>
        /// <param name="colors">Colors define color encoding of data into a visualization.</param>
        /// <param name="note">note.</param>
        /// <param name="showNoteWhenEmpty">if true, will display note when empty.</param>
        public ViewProperties(List<DashboardQuery> queries = default(List<DashboardQuery>), List<DashboardColor> colors = default(List<DashboardColor>), string note = default(string), bool? showNoteWhenEmpty = default(bool?))
        {
            this.Queries = queries;
            this.Colors = colors;
            this.Note = note;
            this.ShowNoteWhenEmpty = showNoteWhenEmpty;
        }

        /// <summary>
        /// Gets or Sets Queries
        /// </summary>
        [DataMember(Name="queries", EmitDefaultValue=false)]
        public List<DashboardQuery> Queries { get; set; }

        /// <summary>
        /// Colors define color encoding of data into a visualization
        /// </summary>
        /// <value>Colors define color encoding of data into a visualization</value>
        [DataMember(Name="colors", EmitDefaultValue=false)]
        public List<DashboardColor> Colors { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// if true, will display note when empty
        /// </summary>
        /// <value>if true, will display note when empty</value>
        [DataMember(Name="showNoteWhenEmpty", EmitDefaultValue=false)]
        public bool? ShowNoteWhenEmpty { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ViewProperties {\n");
            sb.Append("  Queries: ").Append(Queries).Append("\n");
            sb.Append("  Colors: ").Append(Colors).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  ShowNoteWhenEmpty: ").Append(ShowNoteWhenEmpty).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as ViewProperties);
        }

        /// <summary>
        /// Returns true if ViewProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewProperties input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Queries == input.Queries ||
                    this.Queries != null &&
                    this.Queries.SequenceEqual(input.Queries)
                ) && 
                (
                    this.Colors == input.Colors ||
                    this.Colors != null &&
                    this.Colors.SequenceEqual(input.Colors)
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.ShowNoteWhenEmpty == input.ShowNoteWhenEmpty ||
                    (this.ShowNoteWhenEmpty != null &&
                    this.ShowNoteWhenEmpty.Equals(input.ShowNoteWhenEmpty))
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
                int hashCode = 41;
                if (this.Queries != null)
                    hashCode = hashCode * 59 + this.Queries.GetHashCode();
                if (this.Colors != null)
                    hashCode = hashCode * 59 + this.Colors.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.ShowNoteWhenEmpty != null)
                    hashCode = hashCode * 59 + this.ShowNoteWhenEmpty.GetHashCode();
                return hashCode;
            }
        }

    }

}
