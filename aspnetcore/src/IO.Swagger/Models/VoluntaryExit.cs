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
    /// The [&#x60;VoluntaryExit&#x60;](https://github.com/ethereum/eth2.0-specs/blob/dev/specs/core/0_beacon-chain.md#voluntaryexit) object from the Eth2.0 spec.
    /// </summary>
    [DataContract]
    public partial class VoluntaryExit : IEquatable<VoluntaryExit>
    { 
        /// <summary>
        /// Minimum epoch for processing exit.
        /// </summary>
        /// <value>Minimum epoch for processing exit.</value>
        [DataMember(Name="epoch")]
        public int? Epoch { get; set; }

        /// <summary>
        /// Index of the exiting validator.
        /// </summary>
        /// <value>Index of the exiting validator.</value>
        [DataMember(Name="validator_index")]
        public int? ValidatorIndex { get; set; }

        /// <summary>
        /// Validator signature.
        /// </summary>
        /// <value>Validator signature.</value>
        [DataMember(Name="signature")]
        public byte[] Signature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoluntaryExit {\n");
            sb.Append("  Epoch: ").Append(Epoch).Append("\n");
            sb.Append("  ValidatorIndex: ").Append(ValidatorIndex).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
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
            return obj.GetType() == GetType() && Equals((VoluntaryExit)obj);
        }

        /// <summary>
        /// Returns true if VoluntaryExit instances are equal
        /// </summary>
        /// <param name="other">Instance of VoluntaryExit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoluntaryExit other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Epoch == other.Epoch ||
                    Epoch != null &&
                    Epoch.Equals(other.Epoch)
                ) && 
                (
                    ValidatorIndex == other.ValidatorIndex ||
                    ValidatorIndex != null &&
                    ValidatorIndex.Equals(other.ValidatorIndex)
                ) && 
                (
                    Signature == other.Signature ||
                    Signature != null &&
                    Signature.Equals(other.Signature)
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
                    if (Epoch != null)
                    hashCode = hashCode * 59 + Epoch.GetHashCode();
                    if (ValidatorIndex != null)
                    hashCode = hashCode * 59 + ValidatorIndex.GetHashCode();
                    if (Signature != null)
                    hashCode = hashCode * 59 + Signature.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(VoluntaryExit left, VoluntaryExit right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(VoluntaryExit left, VoluntaryExit right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
