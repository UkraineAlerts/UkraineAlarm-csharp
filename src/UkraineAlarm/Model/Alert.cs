/* 
 * Ukraine Alert API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 3.0
 * Contact: support@stfalcon.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = UkraineAlarm.Client.SwaggerDateConverter;
namespace UkraineAlarm.Model
{
    /// <summary>
    /// Alert
    /// </summary>
    [DataContract]
        public partial class Alert :  IEquatable<Alert>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Alert" /> class.
        /// </summary>
        /// <param name="regionId">regionId.</param>
        /// <param name="regionType">regionType.</param>
        /// <param name="type">type.</param>
        /// <param name="lastUpdate">lastUpdate.</param>
        public Alert(string regionId = default(string), V2RegionType regionType = default(V2RegionType), AlertType type = default(AlertType), DateTime? lastUpdate = default(DateTime?))
        {
            this.RegionId = regionId;
            this.RegionType = regionType;
            this.Type = type;
            this.LastUpdate = lastUpdate;
        }
        
        /// <summary>
        /// Gets or Sets RegionId
        /// </summary>
        [DataMember(Name="regionId", EmitDefaultValue=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Gets or Sets RegionType
        /// </summary>
        [DataMember(Name="regionType", EmitDefaultValue=false)]
        public V2RegionType RegionType { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public AlertType Type { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdate
        /// </summary>
        [DataMember(Name="lastUpdate", EmitDefaultValue=false)]
        public DateTime? LastUpdate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Alert {\n");
            sb.Append("  RegionId: ").Append(RegionId).Append("\n");
            sb.Append("  RegionType: ").Append(RegionType).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
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
            return this.Equals(input as Alert);
        }

        /// <summary>
        /// Returns true if Alert instances are equal
        /// </summary>
        /// <param name="input">Instance of Alert to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Alert input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RegionId == input.RegionId ||
                    (this.RegionId != null &&
                    this.RegionId.Equals(input.RegionId))
                ) && 
                (
                    this.RegionType == input.RegionType ||
                    (this.RegionType != null &&
                    this.RegionType.Equals(input.RegionType))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.LastUpdate == input.LastUpdate ||
                    (this.LastUpdate != null &&
                    this.LastUpdate.Equals(input.LastUpdate))
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
                if (this.RegionId != null)
                    hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.RegionType != null)
                    hashCode = hashCode * 59 + this.RegionType.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.LastUpdate != null)
                    hashCode = hashCode * 59 + this.LastUpdate.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
