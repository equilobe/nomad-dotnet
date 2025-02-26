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
    /// ServiceRegistration
    /// </summary>
    [DataContract(Name = "ServiceRegistration")]
    public partial class ServiceRegistration : IEquatable<ServiceRegistration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceRegistration" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="allocID">allocID.</param>
        /// <param name="createIndex">createIndex.</param>
        /// <param name="datacenter">datacenter.</param>
        /// <param name="iD">iD.</param>
        /// <param name="jobID">jobID.</param>
        /// <param name="modifyIndex">modifyIndex.</param>
        /// <param name="_namespace">_namespace.</param>
        /// <param name="nodeID">nodeID.</param>
        /// <param name="port">port.</param>
        /// <param name="serviceName">serviceName.</param>
        /// <param name="tags">tags.</param>
        public ServiceRegistration(string address = default(string), string allocID = default(string), int createIndex = default(int), string datacenter = default(string), string iD = default(string), string jobID = default(string), int modifyIndex = default(int), string _namespace = default(string), string nodeID = default(string), int port = default(int), string serviceName = default(string), List<string> tags = default(List<string>))
        {
            this.Address = address;
            this.AllocID = allocID;
            this.CreateIndex = createIndex;
            this.Datacenter = datacenter;
            this.ID = iD;
            this.JobID = jobID;
            this.ModifyIndex = modifyIndex;
            this.Namespace = _namespace;
            this.NodeID = nodeID;
            this.Port = port;
            this.ServiceName = serviceName;
            this.Tags = tags;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "Address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets AllocID
        /// </summary>
        [DataMember(Name = "AllocID", EmitDefaultValue = false)]
        public string AllocID { get; set; }

        /// <summary>
        /// Gets or Sets CreateIndex
        /// </summary>
        [DataMember(Name = "CreateIndex", EmitDefaultValue = false)]
        public int CreateIndex { get; set; }

        /// <summary>
        /// Gets or Sets Datacenter
        /// </summary>
        [DataMember(Name = "Datacenter", EmitDefaultValue = false)]
        public string Datacenter { get; set; }

        /// <summary>
        /// Gets or Sets ID
        /// </summary>
        [DataMember(Name = "ID", EmitDefaultValue = false)]
        public string ID { get; set; }

        /// <summary>
        /// Gets or Sets JobID
        /// </summary>
        [DataMember(Name = "JobID", EmitDefaultValue = false)]
        public string JobID { get; set; }

        /// <summary>
        /// Gets or Sets ModifyIndex
        /// </summary>
        [DataMember(Name = "ModifyIndex", EmitDefaultValue = false)]
        public int ModifyIndex { get; set; }

        /// <summary>
        /// Gets or Sets Namespace
        /// </summary>
        [DataMember(Name = "Namespace", EmitDefaultValue = false)]
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or Sets NodeID
        /// </summary>
        [DataMember(Name = "NodeID", EmitDefaultValue = false)]
        public string NodeID { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name = "Port", EmitDefaultValue = false)]
        public int Port { get; set; }

        /// <summary>
        /// Gets or Sets ServiceName
        /// </summary>
        [DataMember(Name = "ServiceName", EmitDefaultValue = false)]
        public string ServiceName { get; set; }

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
            sb.Append("class ServiceRegistration {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AllocID: ").Append(AllocID).Append("\n");
            sb.Append("  CreateIndex: ").Append(CreateIndex).Append("\n");
            sb.Append("  Datacenter: ").Append(Datacenter).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  JobID: ").Append(JobID).Append("\n");
            sb.Append("  ModifyIndex: ").Append(ModifyIndex).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  NodeID: ").Append(NodeID).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
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
            return this.Equals(input as ServiceRegistration);
        }

        /// <summary>
        /// Returns true if ServiceRegistration instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceRegistration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceRegistration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.AllocID == input.AllocID ||
                    (this.AllocID != null &&
                    this.AllocID.Equals(input.AllocID))
                ) && 
                (
                    this.CreateIndex == input.CreateIndex ||
                    this.CreateIndex.Equals(input.CreateIndex)
                ) && 
                (
                    this.Datacenter == input.Datacenter ||
                    (this.Datacenter != null &&
                    this.Datacenter.Equals(input.Datacenter))
                ) && 
                (
                    this.ID == input.ID ||
                    (this.ID != null &&
                    this.ID.Equals(input.ID))
                ) && 
                (
                    this.JobID == input.JobID ||
                    (this.JobID != null &&
                    this.JobID.Equals(input.JobID))
                ) && 
                (
                    this.ModifyIndex == input.ModifyIndex ||
                    this.ModifyIndex.Equals(input.ModifyIndex)
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.NodeID == input.NodeID ||
                    (this.NodeID != null &&
                    this.NodeID.Equals(input.NodeID))
                ) && 
                (
                    this.Port == input.Port ||
                    this.Port.Equals(input.Port)
                ) && 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.AllocID != null)
                    hashCode = hashCode * 59 + this.AllocID.GetHashCode();
                hashCode = hashCode * 59 + this.CreateIndex.GetHashCode();
                if (this.Datacenter != null)
                    hashCode = hashCode * 59 + this.Datacenter.GetHashCode();
                if (this.ID != null)
                    hashCode = hashCode * 59 + this.ID.GetHashCode();
                if (this.JobID != null)
                    hashCode = hashCode * 59 + this.JobID.GetHashCode();
                hashCode = hashCode * 59 + this.ModifyIndex.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.NodeID != null)
                    hashCode = hashCode * 59 + this.NodeID.GetHashCode();
                hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.ServiceName != null)
                    hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
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
            // CreateIndex (int) maximum
            if(this.CreateIndex > (int)384)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreateIndex, must be a value less than or equal to 384.", new [] { "CreateIndex" });
            }

            // CreateIndex (int) minimum
            if(this.CreateIndex < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreateIndex, must be a value greater than or equal to 0.", new [] { "CreateIndex" });
            }

            // ModifyIndex (int) maximum
            if(this.ModifyIndex > (int)384)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ModifyIndex, must be a value less than or equal to 384.", new [] { "ModifyIndex" });
            }

            // ModifyIndex (int) minimum
            if(this.ModifyIndex < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ModifyIndex, must be a value greater than or equal to 0.", new [] { "ModifyIndex" });
            }

            yield break;
        }
    }

}
