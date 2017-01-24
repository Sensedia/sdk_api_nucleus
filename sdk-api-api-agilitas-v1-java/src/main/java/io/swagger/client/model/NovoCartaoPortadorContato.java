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

/**
 * NovoCartaoPortadorContato
 */
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-01-23T20:01:43.978Z")
public class NovoCartaoPortadorContato {
  @SerializedName("email")
  private String email = null;

  @SerializedName("telResidencial")
  private String telResidencial = null;

  @SerializedName("telCelular")
  private String telCelular = null;

  public NovoCartaoPortadorContato email(String email) {
    this.email = email;
    return this;
  }

   /**
   * Endereço de email do portador do cartão.
   * @return email
  **/
  @ApiModelProperty(example = "null", value = "Endereço de email do portador do cartão.")
  public String getEmail() {
    return email;
  }

  public void setEmail(String email) {
    this.email = email;
  }

  public NovoCartaoPortadorContato telResidencial(String telResidencial) {
    this.telResidencial = telResidencial;
    return this;
  }

   /**
   * Número do telefone residencial do portador do cartão.
   * @return telResidencial
  **/
  @ApiModelProperty(example = "null", value = "Número do telefone residencial do portador do cartão.")
  public String getTelResidencial() {
    return telResidencial;
  }

  public void setTelResidencial(String telResidencial) {
    this.telResidencial = telResidencial;
  }

  public NovoCartaoPortadorContato telCelular(String telCelular) {
    this.telCelular = telCelular;
    return this;
  }

   /**
   * Número do telefone celular do portador do cartão.
   * @return telCelular
  **/
  @ApiModelProperty(example = "null", value = "Número do telefone celular do portador do cartão.")
  public String getTelCelular() {
    return telCelular;
  }

  public void setTelCelular(String telCelular) {
    this.telCelular = telCelular;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    NovoCartaoPortadorContato novoCartaoPortadorContato = (NovoCartaoPortadorContato) o;
    return Objects.equals(this.email, novoCartaoPortadorContato.email) &&
        Objects.equals(this.telResidencial, novoCartaoPortadorContato.telResidencial) &&
        Objects.equals(this.telCelular, novoCartaoPortadorContato.telCelular);
  }

  @Override
  public int hashCode() {
    return Objects.hash(email, telResidencial, telCelular);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class NovoCartaoPortadorContato {\n");
    
    sb.append("    email: ").append(toIndentedString(email)).append("\n");
    sb.append("    telResidencial: ").append(toIndentedString(telResidencial)).append("\n");
    sb.append("    telCelular: ").append(toIndentedString(telCelular)).append("\n");
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

