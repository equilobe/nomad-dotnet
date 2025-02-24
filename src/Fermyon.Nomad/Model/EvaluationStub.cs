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
    /// EvaluationStub
    /// </summary>
    [DataContract(Name = "EvaluationStub")]
    public partial class EvaluationStub : IEquatable<EvaluationStub>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationStub" /> class.
        /// </summary>
        /// <param name="blockedEval">blockedEval.</param>
        /// <param name="createIndex">createIndex.</param>
        /// <param name="createTime">createTime.</param>
        /// <param name="deploymentID">deploymentID.</param>
        /// <param name="iD">iD.</param>
        /// <param name="jobID">jobID.</param>
        /// <param name="modifyIndex">modifyIndex.</param>
        /// <param name="modifyTime">modifyTime.</param>
        /// <param name="_namespace">_namespace.</param>
        /// <param name="nextEval">nextEval.</param>
        /// <param name="nodeID">nodeID.</param>
        /// <param name="previousEval">previousEval.</param>
        /// <param name="priority">priority.</param>
        /// <param name="status">status.</param>
        /// <param name="statusDescription">statusDescription.</param>
        /// <param name="triggeredBy">triggeredBy.</param>
        /// <param name="type">type.</param>
        /// <param name="waitUntil">waitUntil.</param>
        public EvaluationStub(string blockedEval = default(string), int createIndex = default(int), long createTime = default(long), string deploymentID = default(string), string iD = default(string), string jobID = default(string), int modifyIndex = default(int), long modifyTime = default(long), string _namespace = default(string), string nextEval = default(string), string nodeID = default(string), string previousEval = default(string), int priority = default(int), string status = default(string), string statusDescription = default(string), string triggeredBy = default(string), string type = default(string), DateTime waitUntil = default(DateTime))
        {
            this.BlockedEval = blockedEval;
            this.CreateIndex = createIndex;
            this.CreateTime = createTime;
            this.DeploymentID = deploymentID;
            this.ID = iD;
            this.JobID = jobID;
            this.ModifyIndex = modifyIndex;
            this.ModifyTime = modifyTime;
            this.Namespace = _namespace;
            this.NextEval = nextEval;
            this.NodeID = nodeID;
            this.PreviousEval = previousEval;
            this.Priority = priority;
            this.Status = status;
            this.StatusDescription = statusDescription;
            this.TriggeredBy = triggeredBy;
            this.Type = type;
            this.WaitUntil = waitUntil;
        }

        /// <summary>
        /// Gets or Sets BlockedEval
        /// </summary>
        [DataMember(Name = "BlockedEval", EmitDefaultValue = false)]
        public string BlockedEval { get; set; }

        /// <summary>
        /// Gets or Sets CreateIndex
        /// </summary>
        [DataMember(Name = "CreateIndex", EmitDefaultValue = false)]
        public int CreateIndex { get; set; }

        /// <summary>
        /// Gets or Sets CreateTime
        /// </summary>
        [DataMember(Name = "CreateTime", EmitDefaultValue = false)]
        public long CreateTime { get; set; }

        /// <summary>
        /// Gets or Sets DeploymentID
        /// </summary>
        [DataMember(Name = "DeploymentID", EmitDefaultValue = false)]
        public string DeploymentID { get; set; }

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
        /// Gets or Sets ModifyTime
        /// </summary>
        [DataMember(Name = "ModifyTime", EmitDefaultValue = false)]
        public long ModifyTime { get; set; }

        /// <summary>
        /// Gets or Sets Namespace
        /// </summary>
        [DataMember(Name = "Namespace", EmitDefaultValue = false)]
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or Sets NextEval
        /// </summary>
        [DataMember(Name = "NextEval", EmitDefaultValue = false)]
        public string NextEval { get; set; }

        /// <summary>
        /// Gets or Sets NodeID
        /// </summary>
        [DataMember(Name = "NodeID", EmitDefaultValue = false)]
        public string NodeID { get; set; }

        /// <summary>
        /// Gets or Sets PreviousEval
        /// </summary>
        [DataMember(Name = "PreviousEval", EmitDefaultValue = false)]
        public string PreviousEval { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "Priority", EmitDefaultValue = false)]
        public int Priority { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets StatusDescription
        /// </summary>
        [DataMember(Name = "StatusDescription", EmitDefaultValue = false)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Gets or Sets TriggeredBy
        /// </summary>
        [DataMember(Name = "TriggeredBy", EmitDefaultValue = false)]
        public string TriggeredBy { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "Type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets WaitUntil
        /// </summary>
        [DataMember(Name = "WaitUntil", EmitDefaultValue = false)]
        public DateTime WaitUntil { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationStub {\n");
            sb.Append("  BlockedEval: ").Append(BlockedEval).Append("\n");
            sb.Append("  CreateIndex: ").Append(CreateIndex).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  DeploymentID: ").Append(DeploymentID).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  JobID: ").Append(JobID).Append("\n");
            sb.Append("  ModifyIndex: ").Append(ModifyIndex).Append("\n");
            sb.Append("  ModifyTime: ").Append(ModifyTime).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  NextEval: ").Append(NextEval).Append("\n");
            sb.Append("  NodeID: ").Append(NodeID).Append("\n");
            sb.Append("  PreviousEval: ").Append(PreviousEval).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  TriggeredBy: ").Append(TriggeredBy).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  WaitUntil: ").Append(WaitUntil).Append("\n");
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
            return this.Equals(input as EvaluationStub);
        }

        /// <summary>
        /// Returns true if EvaluationStub instances are equal
        /// </summary>
        /// <param name="input">Instance of EvaluationStub to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationStub input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BlockedEval == input.BlockedEval ||
                    (this.BlockedEval != null &&
                    this.BlockedEval.Equals(input.BlockedEval))
                ) && 
                (
                    this.CreateIndex == input.CreateIndex ||
                    this.CreateIndex.Equals(input.CreateIndex)
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    this.CreateTime.Equals(input.CreateTime)
                ) && 
                (
                    this.DeploymentID == input.DeploymentID ||
                    (this.DeploymentID != null &&
                    this.DeploymentID.Equals(input.DeploymentID))
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
                    this.ModifyTime == input.ModifyTime ||
                    this.ModifyTime.Equals(input.ModifyTime)
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.NextEval == input.NextEval ||
                    (this.NextEval != null &&
                    this.NextEval.Equals(input.NextEval))
                ) && 
                (
                    this.NodeID == input.NodeID ||
                    (this.NodeID != null &&
                    this.NodeID.Equals(input.NodeID))
                ) && 
                (
                    this.PreviousEval == input.PreviousEval ||
                    (this.PreviousEval != null &&
                    this.PreviousEval.Equals(input.PreviousEval))
                ) && 
                (
                    this.Priority == input.Priority ||
                    this.Priority.Equals(input.Priority)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusDescription == input.StatusDescription ||
                    (this.StatusDescription != null &&
                    this.StatusDescription.Equals(input.StatusDescription))
                ) && 
                (
                    this.TriggeredBy == input.TriggeredBy ||
                    (this.TriggeredBy != null &&
                    this.TriggeredBy.Equals(input.TriggeredBy))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.WaitUntil == input.WaitUntil ||
                    (this.WaitUntil != null &&
                    this.WaitUntil.Equals(input.WaitUntil))
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
                if (this.BlockedEval != null)
                    hashCode = hashCode * 59 + this.BlockedEval.GetHashCode();
                hashCode = hashCode * 59 + this.CreateIndex.GetHashCode();
                hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.DeploymentID != null)
                    hashCode = hashCode * 59 + this.DeploymentID.GetHashCode();
                if (this.ID != null)
                    hashCode = hashCode * 59 + this.ID.GetHashCode();
                if (this.JobID != null)
                    hashCode = hashCode * 59 + this.JobID.GetHashCode();
                hashCode = hashCode * 59 + this.ModifyIndex.GetHashCode();
                hashCode = hashCode * 59 + this.ModifyTime.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.NextEval != null)
                    hashCode = hashCode * 59 + this.NextEval.GetHashCode();
                if (this.NodeID != null)
                    hashCode = hashCode * 59 + this.NodeID.GetHashCode();
                if (this.PreviousEval != null)
                    hashCode = hashCode * 59 + this.PreviousEval.GetHashCode();
                hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusDescription != null)
                    hashCode = hashCode * 59 + this.StatusDescription.GetHashCode();
                if (this.TriggeredBy != null)
                    hashCode = hashCode * 59 + this.TriggeredBy.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.WaitUntil != null)
                    hashCode = hashCode * 59 + this.WaitUntil.GetHashCode();
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
