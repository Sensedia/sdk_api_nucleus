/*
 * API Agillitas Cartões Pré-pagos
 * API para manipular recursos relacionadas à cartões pré-pagos Agillitas.
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
import io.swagger.client.model.SetPagamento;

/**
 * Pagamento
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-01-23T20:01:43.978Z")
public class Pagamento {
  @SerializedName("pagamento")
  private SetPagamento pagamento = null;

  public Pagamento pagamento(SetPagamento pagamento) {
    this.pagamento = pagamento;
    return this;
  }

   /**
   * Get pagamento
   * @return pagamento
  **/
  @ApiModelProperty(example = "null", value = "")
  public SetPagamento getPagamento() {
    return pagamento;
  }

  public void setPagamento(SetPagamento pagamento) {
    this.pagamento = pagamento;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Pagamento pagamento = (Pagamento) o;
    return Objects.equals(this.pagamento, pagamento.pagamento);
  }

  @Override
  public int hashCode() {
    return Objects.hash(pagamento);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Pagamento {\n");
    
    sb.append("    pagamento: ").append(toIndentedString(pagamento)).append("\n");
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

