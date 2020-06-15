/*
 * OpenAPI Implementation of Eth 2.0 
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
    /// The [&#x60;BeaconBlockBody&#x60;](https://github.com/ethereum/eth2.0-specs/blob/dev/specs/core/0_beacon-chain.md#beaconblockbody) object from the Eth2.0 spec.
    /// </summary>
    [DataContract]
    public partial class BeaconBlockBody : IEquatable<BeaconBlockBody>
    { 
        /// <summary>
        /// The RanDAO reveal value provided by the validator.
        /// </summary>
        /// <value>The RanDAO reveal value provided by the validator.</value>
        [DataMember(Name="randao_reveal")]
        public byte[] RandaoReveal { get; set; }

        /// <summary>
        /// Gets or Sets Eth1Data
        /// </summary>
        [DataMember(Name="eth1_data")]
        public Eth1Data Eth1Data { get; set; }

        /// <summary>
        /// Gets or Sets Graffiti
        /// </summary>
        [DataMember(Name="graffiti")]
        public byte[] Graffiti { get; set; }

        /// <summary>
        /// Gets or Sets ProposerSlashings
        /// </summary>
        [DataMember(Name="proposer_slashings")]
        public List<ProposerSlashings> ProposerSlashings { get; set; }

        /// <summary>
        /// Gets or Sets AttesterSlashings
        /// </summary>
        [DataMember(Name="attester_slashings")]
        public List<AttesterSlashings> AttesterSlashings { get; set; }

        /// <summary>
        /// Gets or Sets Attestations
        /// </summary>
        [DataMember(Name="attestations")]
        public List<Attestation> Attestations { get; set; }

        /// <summary>
        /// Gets or Sets Deposits
        /// </summary>
        [DataMember(Name="deposits")]
        public List<Deposit> Deposits { get; set; }

        /// <summary>
        /// Gets or Sets VoluntaryExits
        /// </summary>
        [DataMember(Name="voluntary_exits")]
        public List<VoluntaryExit> VoluntaryExits { get; set; }

        /// <summary>
        /// Gets or Sets Transfers
        /// </summary>
        [DataMember(Name="transfers")]
        public List<Transfer> Transfers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BeaconBlockBody {\n");
            sb.Append("  RandaoReveal: ").Append(RandaoReveal).Append("\n");
            sb.Append("  Eth1Data: ").Append(Eth1Data).Append("\n");
            sb.Append("  Graffiti: ").Append(Graffiti).Append("\n");
            sb.Append("  ProposerSlashings: ").Append(ProposerSlashings).Append("\n");
            sb.Append("  AttesterSlashings: ").Append(AttesterSlashings).Append("\n");
            sb.Append("  Attestations: ").Append(Attestations).Append("\n");
            sb.Append("  Deposits: ").Append(Deposits).Append("\n");
            sb.Append("  VoluntaryExits: ").Append(VoluntaryExits).Append("\n");
            sb.Append("  Transfers: ").Append(Transfers).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BeaconBlockBody)obj);
        }

        /// <summary>
        /// Returns true if BeaconBlockBody instances are equal
        /// </summary>
        /// <param name="other">Instance of BeaconBlockBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BeaconBlockBody other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RandaoReveal == other.RandaoReveal ||
                    RandaoReveal != null &&
                    RandaoReveal.Equals(other.RandaoReveal)
                ) && 
                (
                    Eth1Data == other.Eth1Data ||
                    Eth1Data != null &&
                    Eth1Data.Equals(other.Eth1Data)
                ) && 
                (
                    Graffiti == other.Graffiti ||
                    Graffiti != null &&
                    Graffiti.Equals(other.Graffiti)
                ) && 
                (
                    ProposerSlashings == other.ProposerSlashings ||
                    ProposerSlashings != null &&
                    ProposerSlashings.SequenceEqual(other.ProposerSlashings)
                ) && 
                (
                    AttesterSlashings == other.AttesterSlashings ||
                    AttesterSlashings != null &&
                    AttesterSlashings.SequenceEqual(other.AttesterSlashings)
                ) && 
                (
                    Attestations == other.Attestations ||
                    Attestations != null &&
                    Attestations.SequenceEqual(other.Attestations)
                ) && 
                (
                    Deposits == other.Deposits ||
                    Deposits != null &&
                    Deposits.SequenceEqual(other.Deposits)
                ) && 
                (
                    VoluntaryExits == other.VoluntaryExits ||
                    VoluntaryExits != null &&
                    VoluntaryExits.SequenceEqual(other.VoluntaryExits)
                ) && 
                (
                    Transfers == other.Transfers ||
                    Transfers != null &&
                    Transfers.SequenceEqual(other.Transfers)
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
                    if (RandaoReveal != null)
                    hashCode = hashCode * 59 + RandaoReveal.GetHashCode();
                    if (Eth1Data != null)
                    hashCode = hashCode * 59 + Eth1Data.GetHashCode();
                    if (Graffiti != null)
                    hashCode = hashCode * 59 + Graffiti.GetHashCode();
                    if (ProposerSlashings != null)
                    hashCode = hashCode * 59 + ProposerSlashings.GetHashCode();
                    if (AttesterSlashings != null)
                    hashCode = hashCode * 59 + AttesterSlashings.GetHashCode();
                    if (Attestations != null)
                    hashCode = hashCode * 59 + Attestations.GetHashCode();
                    if (Deposits != null)
                    hashCode = hashCode * 59 + Deposits.GetHashCode();
                    if (VoluntaryExits != null)
                    hashCode = hashCode * 59 + VoluntaryExits.GetHashCode();
                    if (Transfers != null)
                    hashCode = hashCode * 59 + Transfers.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BeaconBlockBody left, BeaconBlockBody right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BeaconBlockBody left, BeaconBlockBody right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
