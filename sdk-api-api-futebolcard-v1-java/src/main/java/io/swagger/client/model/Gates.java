/*
 * API do Futebolcard
 * Futebolcard manipulation API
 *
 * OpenAPI spec version: 1.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package io.swagger.client.model;

import java.util.Objects;
import com.google.gson.annotations.SerializedName;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import io.swagger.client.model.InlineResponse2001Sectors;
import java.util.ArrayList;
import java.util.List;

/**
 * Gates
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-05-22T17:08:03.639Z")
public class Gates {
  @SerializedName("gateId")
  private String gateId = null;

  @SerializedName("gateName")
  private String gateName = null;

  @SerializedName("sectors")
  private List<InlineResponse2001Sectors> sectors = new ArrayList<InlineResponse2001Sectors>();

  public Gates gateId(String gateId) {
    this.gateId = gateId;
    return this;
  }

   /**
   * Get gateId
   * @return gateId
  **/
  @ApiModelProperty(example = "831312", value = "")
  public String getGateId() {
    return gateId;
  }

  public void setGateId(String gateId) {
    this.gateId = gateId;
  }

  public Gates gateName(String gateName) {
    this.gateName = gateName;
    return this;
  }

   /**
   * Get gateName
   * @return gateName
  **/
  @ApiModelProperty(example = "Portão 02", value = "")
  public String getGateName() {
    return gateName;
  }

  public void setGateName(String gateName) {
    this.gateName = gateName;
  }

  public Gates sectors(List<InlineResponse2001Sectors> sectors) {
    this.sectors = sectors;
    return this;
  }

  public Gates addSectorsItem(InlineResponse2001Sectors sectorsItem) {
    this.sectors.add(sectorsItem);
    return this;
  }

   /**
   * Get sectors
   * @return sectors
  **/
  @ApiModelProperty(example = "null", value = "")
  public List<InlineResponse2001Sectors> getSectors() {
    return sectors;
  }

  public void setSectors(List<InlineResponse2001Sectors> sectors) {
    this.sectors = sectors;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Gates gates = (Gates) o;
    return Objects.equals(this.gateId, gates.gateId) &&
        Objects.equals(this.gateName, gates.gateName) &&
        Objects.equals(this.sectors, gates.sectors);
  }

  @Override
  public int hashCode() {
    return Objects.hash(gateId, gateName, sectors);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Gates {\n");
    
    sb.append("    gateId: ").append(toIndentedString(gateId)).append("\n");
    sb.append("    gateName: ").append(toIndentedString(gateName)).append("\n");
    sb.append("    sectors: ").append(toIndentedString(sectors)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
  
}
