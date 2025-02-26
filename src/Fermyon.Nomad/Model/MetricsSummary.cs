/*
 * Nomad
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.1.4
 * Contact: support@hashicorp.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Fermyon.Nomad.Client.OpenAPIDateConverter;

namespace Fermyon.Nomad.Model
{
    /// <summary>
    /// MetricsSummary
    /// </summary>
    [DataContract(Name = "MetricsSummary")]
    public partial class MetricsSummary : IEquatable<MetricsSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsSummary" /> class.
        /// </summary>
        /// <param name="counters">counters.</param>
        /// <param name="gauges">gauges.</param>
        /// <param name="points">points.</param>
        /// <param name="samples">samples.</param>
        /// <param name="timestamp">timestamp.</param>
        public MetricsSummary(List<SampledValue> counters = default(List<SampledValue>), List<GaugeValue> gauges = default(List<GaugeValue>), List<PointValue> points = default(List<PointValue>), List<SampledValue> samples = default(List<SampledValue>), string timestamp = default(string))
        {
            this.Counters = counters;
            this.Gauges = gauges;
            this.Points = points;
            this.Samples = samples;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Gets or Sets Counters
        /// </summary>
        [DataMember(Name = "Counters", EmitDefaultValue = false)]
        public List<SampledValue> Counters { get; set; }

        /// <summary>
        /// Gets or Sets Gauges
        /// </summary>
        [DataMember(Name = "Gauges", EmitDefaultValue = false)]
        public List<GaugeValue> Gauges { get; set; }

        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [DataMember(Name = "Points", EmitDefaultValue = false)]
        public List<PointValue> Points { get; set; }

        /// <summary>
        /// Gets or Sets Samples
        /// </summary>
        [DataMember(Name = "Samples", EmitDefaultValue = false)]
        public List<SampledValue> Samples { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "Timestamp", EmitDefaultValue = false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricsSummary {\n");
            sb.Append("  Counters: ").Append(Counters).Append("\n");
            sb.Append("  Gauges: ").Append(Gauges).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  Samples: ").Append(Samples).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetricsSummary);
        }

        /// <summary>
        /// Returns true if MetricsSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of MetricsSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetricsSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Counters == input.Counters ||
                    this.Counters != null &&
                    input.Counters != null &&
                    this.Counters.SequenceEqual(input.Counters)
                ) && 
                (
                    this.Gauges == input.Gauges ||
                    this.Gauges != null &&
                    input.Gauges != null &&
                    this.Gauges.SequenceEqual(input.Gauges)
                ) && 
                (
                    this.Points == input.Points ||
                    this.Points != null &&
                    input.Points != null &&
                    this.Points.SequenceEqual(input.Points)
                ) && 
                (
                    this.Samples == input.Samples ||
                    this.Samples != null &&
                    input.Samples != null &&
                    this.Samples.SequenceEqual(input.Samples)
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.Counters != null)
                    hashCode = hashCode * 59 + this.Counters.GetHashCode();
                if (this.Gauges != null)
                    hashCode = hashCode * 59 + this.Gauges.GetHashCode();
                if (this.Points != null)
                    hashCode = hashCode * 59 + this.Points.GetHashCode();
                if (this.Samples != null)
                    hashCode = hashCode * 59 + this.Samples.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
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
