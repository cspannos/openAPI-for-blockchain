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
    /// The [&#x60;Eth1Data&#x60;](https://github.com/ethereum/eth2.0-specs/blob/dev/specs/core/0_beacon-chain.md#eth1data) object from the Eth2.0 spec.
    /// </summary>
    [DataContract]
    public partial class Eth1Data : IEquatable<Eth1Data>
    { 
        /// <summary>
        /// Root of the deposit tree.
        /// </summary>
        /// <value>Root of the deposit tree.</value>
        [DataMember(Name="deposit_root")]
        public byte[] DepositRoot { get; set; }

        /// <summary>
        /// Total number of deposits.
        /// </summary>
        /// <value>Total number of deposits.</value>
        [DataMember(Name="deposit_count")]
        public int? DepositCount { get; set; }

        /// <summary>
        /// Ethereum 1.x block hash.
        /// </summary>
        /// <value>Ethereum 1.x block hash.</value>
        [DataMember(Name="block_hash")]
        public byte[] BlockHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Eth1Data {\n");
            sb.Append("  DepositRoot: ").Append(DepositRoot).Append("\n");
            sb.Append("  DepositCount: ").Append(DepositCount).Append("\n");
            sb.Append("  BlockHash: ").Append(BlockHash).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Eth1Data)obj);
        }

        /// <summary>
        /// Returns true if Eth1Data instances are equal
        /// </summary>
        /// <param name="other">Instance of Eth1Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Eth1Data other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DepositRoot == other.DepositRoot ||
                    DepositRoot != null &&
                    DepositRoot.Equals(other.DepositRoot)
                ) && 
                (
                    DepositCount == other.DepositCount ||
                    DepositCount != null &&
                    DepositCount.Equals(other.DepositCount)
                ) && 
                (
                    BlockHash == other.BlockHash ||
                    BlockHash != null &&
                    BlockHash.Equals(other.BlockHash)
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
                    if (DepositRoot != null)
                    hashCode = hashCode * 59 + DepositRoot.GetHashCode();
                    if (DepositCount != null)
                    hashCode = hashCode * 59 + DepositCount.GetHashCode();
                    if (BlockHash != null)
                    hashCode = hashCode * 59 + BlockHash.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Eth1Data left, Eth1Data right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Eth1Data left, Eth1Data right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
