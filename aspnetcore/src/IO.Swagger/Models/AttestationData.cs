/*
 * OpenAPI Implementation of Spacemesh API 
 *
 * Minimal OpenAPI specification for Spacemesh public facing API.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// The [&#x60;AttestationData&#x60;](https://github.com/ethereum/eth2.0-specs/blob/dev/specs/core/0_beacon-chain.md#attestationdata) object from the Eth2.0 spec.
    /// </summary>
    [DataContract]
    public partial class AttestationData : IEquatable<AttestationData>
    { 
        /// <summary>
        /// LMD GHOST vote.
        /// </summary>
        /// <value>LMD GHOST vote.</value>
        [DataMember(Name="beacon_block_root")]
        public byte[] BeaconBlockRoot { get; set; }

        /// <summary>
        /// Source epoch from FFG vote.
        /// </summary>
        /// <value>Source epoch from FFG vote.</value>
        [DataMember(Name="source_epoch")]
        public int? SourceEpoch { get; set; }

        /// <summary>
        /// Source root from FFG vote.
        /// </summary>
        /// <value>Source root from FFG vote.</value>
        [DataMember(Name="source_root")]
        public byte[] SourceRoot { get; set; }

        /// <summary>
        /// Target epoch from FFG vote.
        /// </summary>
        /// <value>Target epoch from FFG vote.</value>
        [DataMember(Name="target_epoch")]
        public int? TargetEpoch { get; set; }

        /// <summary>
        /// Target root from FFG vote.
        /// </summary>
        /// <value>Target root from FFG vote.</value>
        [DataMember(Name="target_root")]
        public byte[] TargetRoot { get; set; }

        /// <summary>
        /// Gets or Sets Crosslink
        /// </summary>
        [DataMember(Name="crosslink")]
        public CrossLink Crosslink { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttestationData {\n");
            sb.Append("  BeaconBlockRoot: ").Append(BeaconBlockRoot).Append("\n");
            sb.Append("  SourceEpoch: ").Append(SourceEpoch).Append("\n");
            sb.Append("  SourceRoot: ").Append(SourceRoot).Append("\n");
            sb.Append("  TargetEpoch: ").Append(TargetEpoch).Append("\n");
            sb.Append("  TargetRoot: ").Append(TargetRoot).Append("\n");
            sb.Append("  Crosslink: ").Append(Crosslink).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((AttestationData)obj);
        }

        /// <summary>
        /// Returns true if AttestationData instances are equal
        /// </summary>
        /// <param name="other">Instance of AttestationData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttestationData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    BeaconBlockRoot == other.BeaconBlockRoot ||
                    BeaconBlockRoot != null &&
                    BeaconBlockRoot.Equals(other.BeaconBlockRoot)
                ) && 
                (
                    SourceEpoch == other.SourceEpoch ||
                    SourceEpoch != null &&
                    SourceEpoch.Equals(other.SourceEpoch)
                ) && 
                (
                    SourceRoot == other.SourceRoot ||
                    SourceRoot != null &&
                    SourceRoot.Equals(other.SourceRoot)
                ) && 
                (
                    TargetEpoch == other.TargetEpoch ||
                    TargetEpoch != null &&
                    TargetEpoch.Equals(other.TargetEpoch)
                ) && 
                (
                    TargetRoot == other.TargetRoot ||
                    TargetRoot != null &&
                    TargetRoot.Equals(other.TargetRoot)
                ) && 
                (
                    Crosslink == other.Crosslink ||
                    Crosslink != null &&
                    Crosslink.Equals(other.Crosslink)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (BeaconBlockRoot != null)
                    hashCode = hashCode * 59 + BeaconBlockRoot.GetHashCode();
                    if (SourceEpoch != null)
                    hashCode = hashCode * 59 + SourceEpoch.GetHashCode();
                    if (SourceRoot != null)
                    hashCode = hashCode * 59 + SourceRoot.GetHashCode();
                    if (TargetEpoch != null)
                    hashCode = hashCode * 59 + TargetEpoch.GetHashCode();
                    if (TargetRoot != null)
                    hashCode = hashCode * 59 + TargetRoot.GetHashCode();
                    if (Crosslink != null)
                    hashCode = hashCode * 59 + Crosslink.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AttestationData left, AttestationData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AttestationData left, AttestationData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
