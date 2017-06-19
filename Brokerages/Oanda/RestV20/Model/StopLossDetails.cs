/* 
 * OANDA v20 REST API
 *
 * The full OANDA v20 REST API Specification. This specification defines how to interact with v20 Accounts, Trades, Orders, Pricing and more.
 *
 * OpenAPI spec version: 3.0.15
 * Contact: api@oanda.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Oanda.RestV20.Model
{
    /// <summary>
    /// StopLossDetails specifies the details of a Stop Loss Order to be created on behalf of a client. This may happen when an Order is filled that opens a Trade requiring a Stop Loss, or when a Trade&#39;s dependent Stop Loss Order is modified directly through the Trade.
    /// </summary>
    [DataContract]
    public partial class StopLossDetails :  IEquatable<StopLossDetails>, IValidatableObject
    {
        /// <summary>
        /// The time in force for the created Stop Loss Order. This may only be GTC, GTD or GFD.
        /// </summary>
        /// <value>The time in force for the created Stop Loss Order. This may only be GTC, GTD or GFD.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TimeInForceEnum
        {
            
            /// <summary>
            /// Enum GTC for "GTC"
            /// </summary>
            [EnumMember(Value = "GTC")]
            GTC,
            
            /// <summary>
            /// Enum GTD for "GTD"
            /// </summary>
            [EnumMember(Value = "GTD")]
            GTD,
            
            /// <summary>
            /// Enum GFD for "GFD"
            /// </summary>
            [EnumMember(Value = "GFD")]
            GFD,
            
            /// <summary>
            /// Enum FOK for "FOK"
            /// </summary>
            [EnumMember(Value = "FOK")]
            FOK,
            
            /// <summary>
            /// Enum IOC for "IOC"
            /// </summary>
            [EnumMember(Value = "IOC")]
            IOC
        }

        /// <summary>
        /// The time in force for the created Stop Loss Order. This may only be GTC, GTD or GFD.
        /// </summary>
        /// <value>The time in force for the created Stop Loss Order. This may only be GTC, GTD or GFD.</value>
        [DataMember(Name="timeInForce", EmitDefaultValue=false)]
        public TimeInForceEnum? TimeInForce { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StopLossDetails" /> class.
        /// </summary>
        /// <param name="Price">The price that the Stop Loss Order will be triggered at..</param>
        /// <param name="TimeInForce">The time in force for the created Stop Loss Order. This may only be GTC, GTD or GFD..</param>
        /// <param name="GtdTime">The date when the Stop Loss Order will be cancelled on if timeInForce is GTD..</param>
        /// <param name="ClientExtensions">ClientExtensions.</param>
        public StopLossDetails(string Price = default(string), TimeInForceEnum? TimeInForce = default(TimeInForceEnum?), string GtdTime = default(string), ClientExtensions ClientExtensions = default(ClientExtensions))
        {
            this.Price = Price;
            this.TimeInForce = TimeInForce;
            this.GtdTime = GtdTime;
            this.ClientExtensions = ClientExtensions;
        }
        
        /// <summary>
        /// The price that the Stop Loss Order will be triggered at.
        /// </summary>
        /// <value>The price that the Stop Loss Order will be triggered at.</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public string Price { get; set; }
        /// <summary>
        /// The date when the Stop Loss Order will be cancelled on if timeInForce is GTD.
        /// </summary>
        /// <value>The date when the Stop Loss Order will be cancelled on if timeInForce is GTD.</value>
        [DataMember(Name="gtdTime", EmitDefaultValue=false)]
        public string GtdTime { get; set; }
        /// <summary>
        /// Gets or Sets ClientExtensions
        /// </summary>
        [DataMember(Name="clientExtensions", EmitDefaultValue=false)]
        public ClientExtensions ClientExtensions { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StopLossDetails {\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  GtdTime: ").Append(GtdTime).Append("\n");
            sb.Append("  ClientExtensions: ").Append(ClientExtensions).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as StopLossDetails);
        }

        /// <summary>
        /// Returns true if StopLossDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of StopLossDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StopLossDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) && 
                (
                    this.TimeInForce == other.TimeInForce ||
                    this.TimeInForce != null &&
                    this.TimeInForce.Equals(other.TimeInForce)
                ) && 
                (
                    this.GtdTime == other.GtdTime ||
                    this.GtdTime != null &&
                    this.GtdTime.Equals(other.GtdTime)
                ) && 
                (
                    this.ClientExtensions == other.ClientExtensions ||
                    this.ClientExtensions != null &&
                    this.ClientExtensions.Equals(other.ClientExtensions)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();
                if (this.TimeInForce != null)
                    hash = hash * 59 + this.TimeInForce.GetHashCode();
                if (this.GtdTime != null)
                    hash = hash * 59 + this.GtdTime.GetHashCode();
                if (this.ClientExtensions != null)
                    hash = hash * 59 + this.ClientExtensions.GetHashCode();
                return hash;
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
