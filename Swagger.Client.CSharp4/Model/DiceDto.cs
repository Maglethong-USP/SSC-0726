/* 
 * Contacts API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
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
using SwaggerDateConverter = Swagger.Client.CSharp4.Client.SwaggerDateConverter;

namespace Swagger.Client.CSharp4.Model
{
    /// <summary>
    /// DiceDto
    /// </summary>
    [DataContract]
    public partial class DiceDto :  IEquatable<DiceDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiceDto" /> class.
        /// </summary>
        /// <param name="sum">sum.</param>
        /// <param name="avg">avg.</param>
        /// <param name="values">values.</param>
        /// <param name="distrib">distrib.</param>
        public DiceDto(int? sum = default(int?), double? avg = default(double?), List<int?> values = default(List<int?>), Dictionary<string, int?> distrib = default(Dictionary<string, int?>))
        {
            this.Sum = sum;
            this.Avg = avg;
            this.Values = values;
            this.Distrib = distrib;
        }
        
        /// <summary>
        /// Gets or Sets Sum
        /// </summary>
        [DataMember(Name="sum", EmitDefaultValue=false)]
        public int? Sum { get; set; }

        /// <summary>
        /// Gets or Sets Avg
        /// </summary>
        [DataMember(Name="avg", EmitDefaultValue=false)]
        public double? Avg { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<int?> Values { get; set; }

        /// <summary>
        /// Gets or Sets Distrib
        /// </summary>
        [DataMember(Name="distrib", EmitDefaultValue=false)]
        public Dictionary<string, int?> Distrib { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiceDto {\n");
            sb.Append("  Sum: ").Append(Sum).Append("\n");
            sb.Append("  Avg: ").Append(Avg).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  Distrib: ").Append(Distrib).Append("\n");
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
            return this.Equals(input as DiceDto);
        }

        /// <summary>
        /// Returns true if DiceDto instances are equal
        /// </summary>
        /// <param name="input">Instance of DiceDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiceDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sum == input.Sum ||
                    (this.Sum != null &&
                    this.Sum.Equals(input.Sum))
                ) && 
                (
                    this.Avg == input.Avg ||
                    (this.Avg != null &&
                    this.Avg.Equals(input.Avg))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.Distrib == input.Distrib ||
                    this.Distrib != null &&
                    this.Distrib.SequenceEqual(input.Distrib)
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
                if (this.Sum != null)
                    hashCode = hashCode * 59 + this.Sum.GetHashCode();
                if (this.Avg != null)
                    hashCode = hashCode * 59 + this.Avg.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.Distrib != null)
                    hashCode = hashCode * 59 + this.Distrib.GetHashCode();
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
