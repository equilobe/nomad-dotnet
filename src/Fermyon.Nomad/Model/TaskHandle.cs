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
    /// TaskHandle
    /// </summary>
    [DataContract(Name = "TaskHandle")]
    public partial class TaskHandle : IEquatable<TaskHandle>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskHandle" /> class.
        /// </summary>
        /// <param name="driverState">driverState.</param>
        /// <param name="version">version.</param>
        public TaskHandle(byte[] driverState = default(byte[]), int version = default(int))
        {
            this.DriverState = driverState;
            this.Version = version;
        }

        /// <summary>
        /// Gets or Sets DriverState
        /// </summary>
        [DataMember(Name = "DriverState", EmitDefaultValue = false)]
        public byte[] DriverState { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name = "Version", EmitDefaultValue = false)]
        public int Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskHandle {\n");
            sb.Append("  DriverState: ").Append(DriverState).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as TaskHandle);
        }

        /// <summary>
        /// Returns true if TaskHandle instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskHandle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskHandle input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DriverState == input.DriverState ||
                    (this.DriverState != null &&
                    this.DriverState.Equals(input.DriverState))
                ) && 
                (
                    this.Version == input.Version ||
                    this.Version.Equals(input.Version)
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
                if (this.DriverState != null)
                    hashCode = hashCode * 59 + this.DriverState.GetHashCode();
                hashCode = hashCode * 59 + this.Version.GetHashCode();
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
