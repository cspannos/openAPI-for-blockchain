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
    /// The [&#x60;Attestation&#x60;](https://github.com/ethereum/eth2.0-specs/blob/dev/specs/core/0_beacon-chain.md#attestation) object from the Eth2.0 spec.
    /// </summary>
    [DataContract]
    public partial class Attestation : IEquatable<Attestation>
    { 
        /// <summary>
        /// Attester aggregation bitfield.
        /// </summary>
        /// <value>Attester aggregation bitfield.</value>
        [DataMember(Name="aggregation_bitfield")]
        public byte[] AggregationBitfield { get; set; }

        /// <summary>
        /// Custody bitfield.
        /// </summary>
        /// <value>Custody bitfield.</value>
        [DataMember(Name="custody_bitfield")]
        public byte[] CustodyBitfield { get; set; }

        /// <summary>
        /// BLS aggregate signature.
        /// </summary>
        /// <value>BLS aggregate signature.</value>
        [DataMember(Name="signature")]
        public byte[] Signature { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data")]
        public AttestationData Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Attestation {\n");
            sb.Append("  AggregationBitfield: ").Append(AggregationBitfield).Append("\n");
            sb.Append("  CustodyBitfield: ").Append(CustodyBitfield).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Attestation)obj);
        }

        /// <summary>
        /// Returns true if Attestation instances are equal
        /// </summary>
        /// <param name="other">Instance of Attestation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Attestation other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AggregationBitfield == other.AggregationBitfield ||
                    AggregationBitfield != null &&
                    AggregationBitfield.Equals(other.AggregationBitfield)
                ) && 
                (
                    CustodyBitfield == other.CustodyBitfield ||
                    CustodyBitfield != null &&
                    CustodyBitfield.Equals(other.CustodyBitfield)
                ) && 
                (
                    Signature == other.Signature ||
                    Signature != null &&
                    Signature.Equals(other.Signature)
                ) && 
                (
                    Data == other.Data ||
                    Data != null &&
                    Data.Equals(other.Data)
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
                    if (AggregationBitfield != null)
                    hashCode = hashCode * 59 + AggregationBitfield.GetHashCode();
                    if (CustodyBitfield != null)
                    hashCode = hashCode * 59 + CustodyBitfield.GetHashCode();
                    if (Signature != null)
                    hashCode = hashCode * 59 + Signature.GetHashCode();
                    if (Data != null)
                    hashCode = hashCode * 59 + Data.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Attestation left, Attestation right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Attestation left, Attestation right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
