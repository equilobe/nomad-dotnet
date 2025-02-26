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
    /// ConsulGateway
    /// </summary>
    [DataContract(Name = "ConsulGateway")]
    public partial class ConsulGateway : IEquatable<ConsulGateway>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsulGateway" /> class.
        /// </summary>
        /// <param name="ingress">ingress.</param>
        /// <param name="mesh">mesh.</param>
        /// <param name="proxy">proxy.</param>
        /// <param name="terminating">terminating.</param>
        public ConsulGateway(ConsulIngressConfigEntry ingress = default(ConsulIngressConfigEntry), Object mesh = default(Object), ConsulGatewayProxy proxy = default(ConsulGatewayProxy), ConsulTerminatingConfigEntry terminating = default(ConsulTerminatingConfigEntry))
        {
            this.Ingress = ingress;
            this.Mesh = mesh;
            this.Proxy = proxy;
            this.Terminating = terminating;
        }

        /// <summary>
        /// Gets or Sets Ingress
        /// </summary>
        [DataMember(Name = "Ingress", EmitDefaultValue = false)]
        public ConsulIngressConfigEntry Ingress { get; set; }

        /// <summary>
        /// Gets or Sets Mesh
        /// </summary>
        [DataMember(Name = "Mesh", EmitDefaultValue = true)]
        public Object Mesh { get; set; }

        /// <summary>
        /// Gets or Sets Proxy
        /// </summary>
        [DataMember(Name = "Proxy", EmitDefaultValue = false)]
        public ConsulGatewayProxy Proxy { get; set; }

        /// <summary>
        /// Gets or Sets Terminating
        /// </summary>
        [DataMember(Name = "Terminating", EmitDefaultValue = false)]
        public ConsulTerminatingConfigEntry Terminating { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsulGateway {\n");
            sb.Append("  Ingress: ").Append(Ingress).Append("\n");
            sb.Append("  Mesh: ").Append(Mesh).Append("\n");
            sb.Append("  Proxy: ").Append(Proxy).Append("\n");
            sb.Append("  Terminating: ").Append(Terminating).Append("\n");
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
            return this.Equals(input as ConsulGateway);
        }

        /// <summary>
        /// Returns true if ConsulGateway instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsulGateway to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsulGateway input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ingress == input.Ingress ||
                    (this.Ingress != null &&
                    this.Ingress.Equals(input.Ingress))
                ) && 
                (
                    this.Mesh == input.Mesh ||
                    (this.Mesh != null &&
                    this.Mesh.Equals(input.Mesh))
                ) && 
                (
                    this.Proxy == input.Proxy ||
                    (this.Proxy != null &&
                    this.Proxy.Equals(input.Proxy))
                ) && 
                (
                    this.Terminating == input.Terminating ||
                    (this.Terminating != null &&
                    this.Terminating.Equals(input.Terminating))
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
                if (this.Ingress != null)
                    hashCode = hashCode * 59 + this.Ingress.GetHashCode();
                if (this.Mesh != null)
                    hashCode = hashCode * 59 + this.Mesh.GetHashCode();
                if (this.Proxy != null)
                    hashCode = hashCode * 59 + this.Proxy.GetHashCode();
                if (this.Terminating != null)
                    hashCode = hashCode * 59 + this.Terminating.GetHashCode();
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
