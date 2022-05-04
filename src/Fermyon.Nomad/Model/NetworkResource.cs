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
    /// NetworkResource
    /// </summary>
    [DataContract(Name = "NetworkResource")]
    public partial class NetworkResource : IEquatable<NetworkResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkResource" /> class.
        /// </summary>
        /// <param name="cIDR">cIDR.</param>
        /// <param name="dNS">dNS.</param>
        /// <param name="device">device.</param>
        /// <param name="dynamicPorts">dynamicPorts.</param>
        /// <param name="hostname">hostname.</param>
        /// <param name="iP">iP.</param>
        /// <param name="mBits">mBits.</param>
        /// <param name="mode">mode.</param>
        /// <param name="reservedPorts">reservedPorts.</param>
        public NetworkResource(string cIDR = default(string), DNSConfig dNS = default(DNSConfig), string device = default(string), List<Port> dynamicPorts = default(List<Port>), string hostname = default(string), string iP = default(string), int mBits = default(int), string mode = default(string), List<Port> reservedPorts = default(List<Port>))
        {
            this.CIDR = cIDR;
            this.DNS = dNS;
            this.Device = device;
            this.DynamicPorts = dynamicPorts;
            this.Hostname = hostname;
            this.IP = iP;
            this.MBits = mBits;
            this.Mode = mode;
            this.ReservedPorts = reservedPorts;
        }

        /// <summary>
        /// Gets or Sets CIDR
        /// </summary>
        [DataMember(Name = "CIDR", EmitDefaultValue = false)]
        public string CIDR { get; set; }

        /// <summary>
        /// Gets or Sets DNS
        /// </summary>
        [DataMember(Name = "DNS", EmitDefaultValue = false)]
        public DNSConfig DNS { get; set; }

        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [DataMember(Name = "Device", EmitDefaultValue = false)]
        public string Device { get; set; }

        /// <summary>
        /// Gets or Sets DynamicPorts
        /// </summary>
        [DataMember(Name = "DynamicPorts", EmitDefaultValue = false)]
        public List<Port> DynamicPorts { get; set; }

        /// <summary>
        /// Gets or Sets Hostname
        /// </summary>
        [DataMember(Name = "Hostname", EmitDefaultValue = false)]
        public string Hostname { get; set; }

        /// <summary>
        /// Gets or Sets IP
        /// </summary>
        [DataMember(Name = "IP", EmitDefaultValue = false)]
        public string IP { get; set; }

        /// <summary>
        /// Gets or Sets MBits
        /// </summary>
        [DataMember(Name = "MBits", EmitDefaultValue = false)]
        public int MBits { get; set; }

        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name = "Mode", EmitDefaultValue = false)]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or Sets ReservedPorts
        /// </summary>
        [DataMember(Name = "ReservedPorts", EmitDefaultValue = false)]
        public List<Port> ReservedPorts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NetworkResource {\n");
            sb.Append("  CIDR: ").Append(CIDR).Append("\n");
            sb.Append("  DNS: ").Append(DNS).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  DynamicPorts: ").Append(DynamicPorts).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
            sb.Append("  IP: ").Append(IP).Append("\n");
            sb.Append("  MBits: ").Append(MBits).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  ReservedPorts: ").Append(ReservedPorts).Append("\n");
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
            return this.Equals(input as NetworkResource);
        }

        /// <summary>
        /// Returns true if NetworkResource instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkResource input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CIDR == input.CIDR ||
                    (this.CIDR != null &&
                    this.CIDR.Equals(input.CIDR))
                ) && 
                (
                    this.DNS == input.DNS ||
                    (this.DNS != null &&
                    this.DNS.Equals(input.DNS))
                ) && 
                (
                    this.Device == input.Device ||
                    (this.Device != null &&
                    this.Device.Equals(input.Device))
                ) && 
                (
                    this.DynamicPorts == input.DynamicPorts ||
                    this.DynamicPorts != null &&
                    input.DynamicPorts != null &&
                    this.DynamicPorts.SequenceEqual(input.DynamicPorts)
                ) && 
                (
                    this.Hostname == input.Hostname ||
                    (this.Hostname != null &&
                    this.Hostname.Equals(input.Hostname))
                ) && 
                (
                    this.IP == input.IP ||
                    (this.IP != null &&
                    this.IP.Equals(input.IP))
                ) && 
                (
                    this.MBits == input.MBits ||
                    this.MBits.Equals(input.MBits)
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.ReservedPorts == input.ReservedPorts ||
                    this.ReservedPorts != null &&
                    input.ReservedPorts != null &&
                    this.ReservedPorts.SequenceEqual(input.ReservedPorts)
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
                if (this.CIDR != null)
                {
                    hashCode = (hashCode * 59) + this.CIDR.GetHashCode();
                }
                if (this.DNS != null)
                {
                    hashCode = (hashCode * 59) + this.DNS.GetHashCode();
                }
                if (this.Device != null)
                {
                    hashCode = (hashCode * 59) + this.Device.GetHashCode();
                }
                if (this.DynamicPorts != null)
                {
                    hashCode = (hashCode * 59) + this.DynamicPorts.GetHashCode();
                }
                if (this.Hostname != null)
                {
                    hashCode = (hashCode * 59) + this.Hostname.GetHashCode();
                }
                if (this.IP != null)
                {
                    hashCode = (hashCode * 59) + this.IP.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MBits.GetHashCode();
                if (this.Mode != null)
                {
                    hashCode = (hashCode * 59) + this.Mode.GetHashCode();
                }
                if (this.ReservedPorts != null)
                {
                    hashCode = (hashCode * 59) + this.ReservedPorts.GetHashCode();
                }
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
