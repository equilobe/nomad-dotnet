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
    /// NodeMemoryResources
    /// </summary>
    [DataContract(Name = "NodeMemoryResources")]
    public partial class NodeMemoryResources : IEquatable<NodeMemoryResources>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeMemoryResources" /> class.
        /// </summary>
        /// <param name="memoryMB">memoryMB.</param>
        public NodeMemoryResources(long memoryMB = default(long))
        {
            this.MemoryMB = memoryMB;
        }

        /// <summary>
        /// Gets or Sets MemoryMB
        /// </summary>
        [DataMember(Name = "MemoryMB", EmitDefaultValue = false)]
        public long MemoryMB { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NodeMemoryResources {\n");
            sb.Append("  MemoryMB: ").Append(MemoryMB).Append("\n");
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
            return this.Equals(input as NodeMemoryResources);
        }

        /// <summary>
        /// Returns true if NodeMemoryResources instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeMemoryResources to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeMemoryResources input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MemoryMB == input.MemoryMB ||
                    this.MemoryMB.Equals(input.MemoryMB)
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
                hashCode = (hashCode * 59) + this.MemoryMB.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
