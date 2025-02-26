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
    /// AllocatedSharedResources
    /// </summary>
    [DataContract(Name = "AllocatedSharedResources")]
    public partial class AllocatedSharedResources : IEquatable<AllocatedSharedResources>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllocatedSharedResources" /> class.
        /// </summary>
        /// <param name="diskMB">diskMB.</param>
        /// <param name="networks">networks.</param>
        /// <param name="ports">ports.</param>
        public AllocatedSharedResources(long diskMB = default(long), List<NetworkResource> networks = default(List<NetworkResource>), List<PortMapping> ports = default(List<PortMapping>))
        {
            this.DiskMB = diskMB;
            this.Networks = networks;
            this.Ports = ports;
        }

        /// <summary>
        /// Gets or Sets DiskMB
        /// </summary>
        [DataMember(Name = "DiskMB", EmitDefaultValue = false)]
        public long DiskMB { get; set; }

        /// <summary>
        /// Gets or Sets Networks
        /// </summary>
        [DataMember(Name = "Networks", EmitDefaultValue = false)]
        public List<NetworkResource> Networks { get; set; }

        /// <summary>
        /// Gets or Sets Ports
        /// </summary>
        [DataMember(Name = "Ports", EmitDefaultValue = false)]
        public List<PortMapping> Ports { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllocatedSharedResources {\n");
            sb.Append("  DiskMB: ").Append(DiskMB).Append("\n");
            sb.Append("  Networks: ").Append(Networks).Append("\n");
            sb.Append("  Ports: ").Append(Ports).Append("\n");
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
            return this.Equals(input as AllocatedSharedResources);
        }

        /// <summary>
        /// Returns true if AllocatedSharedResources instances are equal
        /// </summary>
        /// <param name="input">Instance of AllocatedSharedResources to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllocatedSharedResources input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DiskMB == input.DiskMB ||
                    this.DiskMB.Equals(input.DiskMB)
                ) && 
                (
                    this.Networks == input.Networks ||
                    this.Networks != null &&
                    input.Networks != null &&
                    this.Networks.SequenceEqual(input.Networks)
                ) && 
                (
                    this.Ports == input.Ports ||
                    this.Ports != null &&
                    input.Ports != null &&
                    this.Ports.SequenceEqual(input.Ports)
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
                hashCode = hashCode * 59 + this.DiskMB.GetHashCode();
                if (this.Networks != null)
                    hashCode = hashCode * 59 + this.Networks.GetHashCode();
                if (this.Ports != null)
                    hashCode = hashCode * 59 + this.Ports.GetHashCode();
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
