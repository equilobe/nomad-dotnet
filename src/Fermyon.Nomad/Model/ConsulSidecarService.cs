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
    /// ConsulSidecarService
    /// </summary>
    [DataContract(Name = "ConsulSidecarService")]
    public partial class ConsulSidecarService : IEquatable<ConsulSidecarService>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsulSidecarService" /> class.
        /// </summary>
        /// <param name="disableDefaultTCPCheck">disableDefaultTCPCheck.</param>
        /// <param name="port">port.</param>
        /// <param name="proxy">proxy.</param>
        /// <param name="tags">tags.</param>
        public ConsulSidecarService(bool disableDefaultTCPCheck = default(bool), string port = default(string), ConsulProxy proxy = default(ConsulProxy), List<string> tags = default(List<string>))
        {
            this.DisableDefaultTCPCheck = disableDefaultTCPCheck;
            this.Port = port;
            this.Proxy = proxy;
            this.Tags = tags;
        }

        /// <summary>
        /// Gets or Sets DisableDefaultTCPCheck
        /// </summary>
        [DataMember(Name = "DisableDefaultTCPCheck", EmitDefaultValue = true)]
        public bool DisableDefaultTCPCheck { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name = "Port", EmitDefaultValue = false)]
        public string Port { get; set; }

        /// <summary>
        /// Gets or Sets Proxy
        /// </summary>
        [DataMember(Name = "Proxy", EmitDefaultValue = false)]
        public ConsulProxy Proxy { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "Tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsulSidecarService {\n");
            sb.Append("  DisableDefaultTCPCheck: ").Append(DisableDefaultTCPCheck).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Proxy: ").Append(Proxy).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as ConsulSidecarService);
        }

        /// <summary>
        /// Returns true if ConsulSidecarService instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsulSidecarService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsulSidecarService input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisableDefaultTCPCheck == input.DisableDefaultTCPCheck ||
                    this.DisableDefaultTCPCheck.Equals(input.DisableDefaultTCPCheck)
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.Proxy == input.Proxy ||
                    (this.Proxy != null &&
                    this.Proxy.Equals(input.Proxy))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                hashCode = hashCode * 59 + this.DisableDefaultTCPCheck.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Proxy != null)
                    hashCode = hashCode * 59 + this.Proxy.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
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
