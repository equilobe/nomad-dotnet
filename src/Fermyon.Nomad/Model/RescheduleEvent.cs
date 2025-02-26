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
    /// RescheduleEvent
    /// </summary>
    [DataContract(Name = "RescheduleEvent")]
    public partial class RescheduleEvent : IEquatable<RescheduleEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RescheduleEvent" /> class.
        /// </summary>
        /// <param name="prevAllocID">prevAllocID.</param>
        /// <param name="prevNodeID">prevNodeID.</param>
        /// <param name="rescheduleTime">rescheduleTime.</param>
        public RescheduleEvent(string prevAllocID = default(string), string prevNodeID = default(string), long rescheduleTime = default(long))
        {
            this.PrevAllocID = prevAllocID;
            this.PrevNodeID = prevNodeID;
            this.RescheduleTime = rescheduleTime;
        }

        /// <summary>
        /// Gets or Sets PrevAllocID
        /// </summary>
        [DataMember(Name = "PrevAllocID", EmitDefaultValue = false)]
        public string PrevAllocID { get; set; }

        /// <summary>
        /// Gets or Sets PrevNodeID
        /// </summary>
        [DataMember(Name = "PrevNodeID", EmitDefaultValue = false)]
        public string PrevNodeID { get; set; }

        /// <summary>
        /// Gets or Sets RescheduleTime
        /// </summary>
        [DataMember(Name = "RescheduleTime", EmitDefaultValue = false)]
        public long RescheduleTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RescheduleEvent {\n");
            sb.Append("  PrevAllocID: ").Append(PrevAllocID).Append("\n");
            sb.Append("  PrevNodeID: ").Append(PrevNodeID).Append("\n");
            sb.Append("  RescheduleTime: ").Append(RescheduleTime).Append("\n");
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
            return this.Equals(input as RescheduleEvent);
        }

        /// <summary>
        /// Returns true if RescheduleEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of RescheduleEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RescheduleEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrevAllocID == input.PrevAllocID ||
                    (this.PrevAllocID != null &&
                    this.PrevAllocID.Equals(input.PrevAllocID))
                ) && 
                (
                    this.PrevNodeID == input.PrevNodeID ||
                    (this.PrevNodeID != null &&
                    this.PrevNodeID.Equals(input.PrevNodeID))
                ) && 
                (
                    this.RescheduleTime == input.RescheduleTime ||
                    this.RescheduleTime.Equals(input.RescheduleTime)
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
                if (this.PrevAllocID != null)
                    hashCode = hashCode * 59 + this.PrevAllocID.GetHashCode();
                if (this.PrevNodeID != null)
                    hashCode = hashCode * 59 + this.PrevNodeID.GetHashCode();
                hashCode = hashCode * 59 + this.RescheduleTime.GetHashCode();
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
