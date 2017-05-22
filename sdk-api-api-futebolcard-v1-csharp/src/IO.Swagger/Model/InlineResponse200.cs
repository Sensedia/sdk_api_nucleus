/* 
 * API do Futebolcard
 *
 * Futebolcard manipulation API
 *
 * OpenAPI spec version: 1.0
 * 
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

namespace IO.Swagger.Model
{
    /// <summary>
    /// InlineResponse200
    /// </summary>
    [DataContract]
    public partial class InlineResponse200 :  IEquatable<InlineResponse200>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse200" /> class.
        /// </summary>
        /// <param name="EventId">EventId.</param>
        /// <param name="CategorieName">CategorieName.</param>
        /// <param name="InternetSaleStartDate">InternetSaleStartDate.</param>
        /// <param name="InternetSaleEndDate">InternetSaleEndDate.</param>
        /// <param name="SaleStartDate">SaleStartDate.</param>
        /// <param name="SaleEndDate">SaleEndDate.</param>
        /// <param name="MemberSaleStartDate">MemberSaleStartDate.</param>
        /// <param name="MemberSaleEndDate">MemberSaleEndDate.</param>
        /// <param name="EventDate">EventDate.</param>
        /// <param name="EventTime">EventTime.</param>
        /// <param name="StadiumName">StadiumName.</param>
        /// <param name="City">City.</param>
        /// <param name="State">State.</param>
        /// <param name="PrincipalClub">PrincipalClub.</param>
        /// <param name="OpponentClub">OpponentClub.</param>
        /// <param name="PrincipalClubImage">PrincipalClubImage.</param>
        /// <param name="OpponentClubImage">OpponentClubImage.</param>
        /// <param name="ExpressSale">ExpressSale.</param>
        public InlineResponse200(string EventId = default(string), string CategorieName = default(string), string InternetSaleStartDate = default(string), string InternetSaleEndDate = default(string), string SaleStartDate = default(string), string SaleEndDate = default(string), string MemberSaleStartDate = default(string), string MemberSaleEndDate = default(string), string EventDate = default(string), string EventTime = default(string), string StadiumName = default(string), string City = default(string), string State = default(string), string PrincipalClub = default(string), string OpponentClub = default(string), string PrincipalClubImage = default(string), string OpponentClubImage = default(string), string ExpressSale = default(string))
        {
            this.EventId = EventId;
            this.CategorieName = CategorieName;
            this.InternetSaleStartDate = InternetSaleStartDate;
            this.InternetSaleEndDate = InternetSaleEndDate;
            this.SaleStartDate = SaleStartDate;
            this.SaleEndDate = SaleEndDate;
            this.MemberSaleStartDate = MemberSaleStartDate;
            this.MemberSaleEndDate = MemberSaleEndDate;
            this.EventDate = EventDate;
            this.EventTime = EventTime;
            this.StadiumName = StadiumName;
            this.City = City;
            this.State = State;
            this.PrincipalClub = PrincipalClub;
            this.OpponentClub = OpponentClub;
            this.PrincipalClubImage = PrincipalClubImage;
            this.OpponentClubImage = OpponentClubImage;
            this.ExpressSale = ExpressSale;
        }
        
        /// <summary>
        /// Gets or Sets EventId
        /// </summary>
        [DataMember(Name="eventId", EmitDefaultValue=false)]
        public string EventId { get; set; }
        /// <summary>
        /// Gets or Sets CategorieName
        /// </summary>
        [DataMember(Name="categorieName", EmitDefaultValue=false)]
        public string CategorieName { get; set; }
        /// <summary>
        /// Gets or Sets InternetSaleStartDate
        /// </summary>
        [DataMember(Name="internetSaleStartDate", EmitDefaultValue=false)]
        public string InternetSaleStartDate { get; set; }
        /// <summary>
        /// Gets or Sets InternetSaleEndDate
        /// </summary>
        [DataMember(Name="internetSaleEndDate", EmitDefaultValue=false)]
        public string InternetSaleEndDate { get; set; }
        /// <summary>
        /// Gets or Sets SaleStartDate
        /// </summary>
        [DataMember(Name="saleStartDate", EmitDefaultValue=false)]
        public string SaleStartDate { get; set; }
        /// <summary>
        /// Gets or Sets SaleEndDate
        /// </summary>
        [DataMember(Name="saleEndDate", EmitDefaultValue=false)]
        public string SaleEndDate { get; set; }
        /// <summary>
        /// Gets or Sets MemberSaleStartDate
        /// </summary>
        [DataMember(Name="memberSaleStartDate", EmitDefaultValue=false)]
        public string MemberSaleStartDate { get; set; }
        /// <summary>
        /// Gets or Sets MemberSaleEndDate
        /// </summary>
        [DataMember(Name="memberSaleEndDate", EmitDefaultValue=false)]
        public string MemberSaleEndDate { get; set; }
        /// <summary>
        /// Gets or Sets EventDate
        /// </summary>
        [DataMember(Name="eventDate", EmitDefaultValue=false)]
        public string EventDate { get; set; }
        /// <summary>
        /// Gets or Sets EventTime
        /// </summary>
        [DataMember(Name="eventTime", EmitDefaultValue=false)]
        public string EventTime { get; set; }
        /// <summary>
        /// Gets or Sets StadiumName
        /// </summary>
        [DataMember(Name="stadiumName", EmitDefaultValue=false)]
        public string StadiumName { get; set; }
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
        /// <summary>
        /// Gets or Sets PrincipalClub
        /// </summary>
        [DataMember(Name="principalClub", EmitDefaultValue=false)]
        public string PrincipalClub { get; set; }
        /// <summary>
        /// Gets or Sets OpponentClub
        /// </summary>
        [DataMember(Name="opponentClub", EmitDefaultValue=false)]
        public string OpponentClub { get; set; }
        /// <summary>
        /// Gets or Sets PrincipalClubImage
        /// </summary>
        [DataMember(Name="principalClubImage", EmitDefaultValue=false)]
        public string PrincipalClubImage { get; set; }
        /// <summary>
        /// Gets or Sets OpponentClubImage
        /// </summary>
        [DataMember(Name="opponentClubImage", EmitDefaultValue=false)]
        public string OpponentClubImage { get; set; }
        /// <summary>
        /// Gets or Sets ExpressSale
        /// </summary>
        [DataMember(Name="expressSale", EmitDefaultValue=false)]
        public string ExpressSale { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse200 {\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  CategorieName: ").Append(CategorieName).Append("\n");
            sb.Append("  InternetSaleStartDate: ").Append(InternetSaleStartDate).Append("\n");
            sb.Append("  InternetSaleEndDate: ").Append(InternetSaleEndDate).Append("\n");
            sb.Append("  SaleStartDate: ").Append(SaleStartDate).Append("\n");
            sb.Append("  SaleEndDate: ").Append(SaleEndDate).Append("\n");
            sb.Append("  MemberSaleStartDate: ").Append(MemberSaleStartDate).Append("\n");
            sb.Append("  MemberSaleEndDate: ").Append(MemberSaleEndDate).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  StadiumName: ").Append(StadiumName).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PrincipalClub: ").Append(PrincipalClub).Append("\n");
            sb.Append("  OpponentClub: ").Append(OpponentClub).Append("\n");
            sb.Append("  PrincipalClubImage: ").Append(PrincipalClubImage).Append("\n");
            sb.Append("  OpponentClubImage: ").Append(OpponentClubImage).Append("\n");
            sb.Append("  ExpressSale: ").Append(ExpressSale).Append("\n");
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
            return this.Equals(obj as InlineResponse200);
        }

        /// <summary>
        /// Returns true if InlineResponse200 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse200 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse200 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EventId == other.EventId ||
                    this.EventId != null &&
                    this.EventId.Equals(other.EventId)
                ) && 
                (
                    this.CategorieName == other.CategorieName ||
                    this.CategorieName != null &&
                    this.CategorieName.Equals(other.CategorieName)
                ) && 
                (
                    this.InternetSaleStartDate == other.InternetSaleStartDate ||
                    this.InternetSaleStartDate != null &&
                    this.InternetSaleStartDate.Equals(other.InternetSaleStartDate)
                ) && 
                (
                    this.InternetSaleEndDate == other.InternetSaleEndDate ||
                    this.InternetSaleEndDate != null &&
                    this.InternetSaleEndDate.Equals(other.InternetSaleEndDate)
                ) && 
                (
                    this.SaleStartDate == other.SaleStartDate ||
                    this.SaleStartDate != null &&
                    this.SaleStartDate.Equals(other.SaleStartDate)
                ) && 
                (
                    this.SaleEndDate == other.SaleEndDate ||
                    this.SaleEndDate != null &&
                    this.SaleEndDate.Equals(other.SaleEndDate)
                ) && 
                (
                    this.MemberSaleStartDate == other.MemberSaleStartDate ||
                    this.MemberSaleStartDate != null &&
                    this.MemberSaleStartDate.Equals(other.MemberSaleStartDate)
                ) && 
                (
                    this.MemberSaleEndDate == other.MemberSaleEndDate ||
                    this.MemberSaleEndDate != null &&
                    this.MemberSaleEndDate.Equals(other.MemberSaleEndDate)
                ) && 
                (
                    this.EventDate == other.EventDate ||
                    this.EventDate != null &&
                    this.EventDate.Equals(other.EventDate)
                ) && 
                (
                    this.EventTime == other.EventTime ||
                    this.EventTime != null &&
                    this.EventTime.Equals(other.EventTime)
                ) && 
                (
                    this.StadiumName == other.StadiumName ||
                    this.StadiumName != null &&
                    this.StadiumName.Equals(other.StadiumName)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.PrincipalClub == other.PrincipalClub ||
                    this.PrincipalClub != null &&
                    this.PrincipalClub.Equals(other.PrincipalClub)
                ) && 
                (
                    this.OpponentClub == other.OpponentClub ||
                    this.OpponentClub != null &&
                    this.OpponentClub.Equals(other.OpponentClub)
                ) && 
                (
                    this.PrincipalClubImage == other.PrincipalClubImage ||
                    this.PrincipalClubImage != null &&
                    this.PrincipalClubImage.Equals(other.PrincipalClubImage)
                ) && 
                (
                    this.OpponentClubImage == other.OpponentClubImage ||
                    this.OpponentClubImage != null &&
                    this.OpponentClubImage.Equals(other.OpponentClubImage)
                ) && 
                (
                    this.ExpressSale == other.ExpressSale ||
                    this.ExpressSale != null &&
                    this.ExpressSale.Equals(other.ExpressSale)
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
                if (this.EventId != null)
                    hash = hash * 59 + this.EventId.GetHashCode();
                if (this.CategorieName != null)
                    hash = hash * 59 + this.CategorieName.GetHashCode();
                if (this.InternetSaleStartDate != null)
                    hash = hash * 59 + this.InternetSaleStartDate.GetHashCode();
                if (this.InternetSaleEndDate != null)
                    hash = hash * 59 + this.InternetSaleEndDate.GetHashCode();
                if (this.SaleStartDate != null)
                    hash = hash * 59 + this.SaleStartDate.GetHashCode();
                if (this.SaleEndDate != null)
                    hash = hash * 59 + this.SaleEndDate.GetHashCode();
                if (this.MemberSaleStartDate != null)
                    hash = hash * 59 + this.MemberSaleStartDate.GetHashCode();
                if (this.MemberSaleEndDate != null)
                    hash = hash * 59 + this.MemberSaleEndDate.GetHashCode();
                if (this.EventDate != null)
                    hash = hash * 59 + this.EventDate.GetHashCode();
                if (this.EventTime != null)
                    hash = hash * 59 + this.EventTime.GetHashCode();
                if (this.StadiumName != null)
                    hash = hash * 59 + this.StadiumName.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.PrincipalClub != null)
                    hash = hash * 59 + this.PrincipalClub.GetHashCode();
                if (this.OpponentClub != null)
                    hash = hash * 59 + this.OpponentClub.GetHashCode();
                if (this.PrincipalClubImage != null)
                    hash = hash * 59 + this.PrincipalClubImage.GetHashCode();
                if (this.OpponentClubImage != null)
                    hash = hash * 59 + this.OpponentClubImage.GetHashCode();
                if (this.ExpressSale != null)
                    hash = hash * 59 + this.ExpressSale.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}