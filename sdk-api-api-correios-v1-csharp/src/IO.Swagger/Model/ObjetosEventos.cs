/* 
 * API dos Correios
 *
 * API de rastreios de Objetos Postais
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
    /// Customer Model
    /// </summary>
    [DataContract]
    public partial class ObjetosEventos :  IEquatable<ObjetosEventos>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjetosEventos" /> class.
        /// </summary>
        /// <param name="CodigoObjeto">.</param>
        /// <param name="TipoEvento">.</param>
        /// <param name="StatusEvento">.</param>
        /// <param name="DescricaoEvento">.</param>
        /// <param name="NomeUnidade">.</param>
        /// <param name="CodigoSRO">.</param>
        /// <param name="Municipio">.</param>
        /// <param name="Uf">.</param>
        /// <param name="CodigoMCU">.</param>
        /// <param name="CodigoDR">.</param>
        /// <param name="SiglaDR">.</param>
        /// <param name="NumeroLista">.</param>
        /// <param name="Estacao">.</param>
        /// <param name="Usuario">.</param>
        /// <param name="DataGravacao">.</param>
        /// <param name="Entregador">.</param>
        /// <param name="DataCriacao">.</param>
        /// <param name="AcaoBloqueio">.</param>
        public ObjetosEventos(string CodigoObjeto = default(string), string TipoEvento = default(string), int? StatusEvento = default(int?), string DescricaoEvento = default(string), string NomeUnidade = default(string), string CodigoSRO = default(string), string Municipio = default(string), string Uf = default(string), string CodigoMCU = default(string), string CodigoDR = default(string), string SiglaDR = default(string), string NumeroLista = default(string), int? Estacao = default(int?), string Usuario = default(string), string DataGravacao = default(string), string Entregador = default(string), string DataCriacao = default(string), int? AcaoBloqueio = default(int?))
        {
            this.CodigoObjeto = CodigoObjeto;
            this.TipoEvento = TipoEvento;
            this.StatusEvento = StatusEvento;
            this.DescricaoEvento = DescricaoEvento;
            this.NomeUnidade = NomeUnidade;
            this.CodigoSRO = CodigoSRO;
            this.Municipio = Municipio;
            this.Uf = Uf;
            this.CodigoMCU = CodigoMCU;
            this.CodigoDR = CodigoDR;
            this.SiglaDR = SiglaDR;
            this.NumeroLista = NumeroLista;
            this.Estacao = Estacao;
            this.Usuario = Usuario;
            this.DataGravacao = DataGravacao;
            this.Entregador = Entregador;
            this.DataCriacao = DataCriacao;
            this.AcaoBloqueio = AcaoBloqueio;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="codigoObjeto", EmitDefaultValue=false)]
        public string CodigoObjeto { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="tipoEvento", EmitDefaultValue=false)]
        public string TipoEvento { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="statusEvento", EmitDefaultValue=false)]
        public int? StatusEvento { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="descricaoEvento", EmitDefaultValue=false)]
        public string DescricaoEvento { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="nomeUnidade", EmitDefaultValue=false)]
        public string NomeUnidade { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="codigoSRO", EmitDefaultValue=false)]
        public string CodigoSRO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="municipio", EmitDefaultValue=false)]
        public string Municipio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="uf", EmitDefaultValue=false)]
        public string Uf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="codigoMCU", EmitDefaultValue=false)]
        public string CodigoMCU { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="codigoDR", EmitDefaultValue=false)]
        public string CodigoDR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="siglaDR", EmitDefaultValue=false)]
        public string SiglaDR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="numeroLista", EmitDefaultValue=false)]
        public string NumeroLista { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="estacao", EmitDefaultValue=false)]
        public int? Estacao { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="usuario", EmitDefaultValue=false)]
        public string Usuario { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="dataGravacao", EmitDefaultValue=false)]
        public string DataGravacao { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="entregador", EmitDefaultValue=false)]
        public string Entregador { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="dataCriacao", EmitDefaultValue=false)]
        public string DataCriacao { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="acaoBloqueio", EmitDefaultValue=false)]
        public int? AcaoBloqueio { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjetosEventos {\n");
            sb.Append("  CodigoObjeto: ").Append(CodigoObjeto).Append("\n");
            sb.Append("  TipoEvento: ").Append(TipoEvento).Append("\n");
            sb.Append("  StatusEvento: ").Append(StatusEvento).Append("\n");
            sb.Append("  DescricaoEvento: ").Append(DescricaoEvento).Append("\n");
            sb.Append("  NomeUnidade: ").Append(NomeUnidade).Append("\n");
            sb.Append("  CodigoSRO: ").Append(CodigoSRO).Append("\n");
            sb.Append("  Municipio: ").Append(Municipio).Append("\n");
            sb.Append("  Uf: ").Append(Uf).Append("\n");
            sb.Append("  CodigoMCU: ").Append(CodigoMCU).Append("\n");
            sb.Append("  CodigoDR: ").Append(CodigoDR).Append("\n");
            sb.Append("  SiglaDR: ").Append(SiglaDR).Append("\n");
            sb.Append("  NumeroLista: ").Append(NumeroLista).Append("\n");
            sb.Append("  Estacao: ").Append(Estacao).Append("\n");
            sb.Append("  Usuario: ").Append(Usuario).Append("\n");
            sb.Append("  DataGravacao: ").Append(DataGravacao).Append("\n");
            sb.Append("  Entregador: ").Append(Entregador).Append("\n");
            sb.Append("  DataCriacao: ").Append(DataCriacao).Append("\n");
            sb.Append("  AcaoBloqueio: ").Append(AcaoBloqueio).Append("\n");
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
            return this.Equals(obj as ObjetosEventos);
        }

        /// <summary>
        /// Returns true if ObjetosEventos instances are equal
        /// </summary>
        /// <param name="other">Instance of ObjetosEventos to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjetosEventos other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CodigoObjeto == other.CodigoObjeto ||
                    this.CodigoObjeto != null &&
                    this.CodigoObjeto.Equals(other.CodigoObjeto)
                ) && 
                (
                    this.TipoEvento == other.TipoEvento ||
                    this.TipoEvento != null &&
                    this.TipoEvento.Equals(other.TipoEvento)
                ) && 
                (
                    this.StatusEvento == other.StatusEvento ||
                    this.StatusEvento != null &&
                    this.StatusEvento.Equals(other.StatusEvento)
                ) && 
                (
                    this.DescricaoEvento == other.DescricaoEvento ||
                    this.DescricaoEvento != null &&
                    this.DescricaoEvento.Equals(other.DescricaoEvento)
                ) && 
                (
                    this.NomeUnidade == other.NomeUnidade ||
                    this.NomeUnidade != null &&
                    this.NomeUnidade.Equals(other.NomeUnidade)
                ) && 
                (
                    this.CodigoSRO == other.CodigoSRO ||
                    this.CodigoSRO != null &&
                    this.CodigoSRO.Equals(other.CodigoSRO)
                ) && 
                (
                    this.Municipio == other.Municipio ||
                    this.Municipio != null &&
                    this.Municipio.Equals(other.Municipio)
                ) && 
                (
                    this.Uf == other.Uf ||
                    this.Uf != null &&
                    this.Uf.Equals(other.Uf)
                ) && 
                (
                    this.CodigoMCU == other.CodigoMCU ||
                    this.CodigoMCU != null &&
                    this.CodigoMCU.Equals(other.CodigoMCU)
                ) && 
                (
                    this.CodigoDR == other.CodigoDR ||
                    this.CodigoDR != null &&
                    this.CodigoDR.Equals(other.CodigoDR)
                ) && 
                (
                    this.SiglaDR == other.SiglaDR ||
                    this.SiglaDR != null &&
                    this.SiglaDR.Equals(other.SiglaDR)
                ) && 
                (
                    this.NumeroLista == other.NumeroLista ||
                    this.NumeroLista != null &&
                    this.NumeroLista.Equals(other.NumeroLista)
                ) && 
                (
                    this.Estacao == other.Estacao ||
                    this.Estacao != null &&
                    this.Estacao.Equals(other.Estacao)
                ) && 
                (
                    this.Usuario == other.Usuario ||
                    this.Usuario != null &&
                    this.Usuario.Equals(other.Usuario)
                ) && 
                (
                    this.DataGravacao == other.DataGravacao ||
                    this.DataGravacao != null &&
                    this.DataGravacao.Equals(other.DataGravacao)
                ) && 
                (
                    this.Entregador == other.Entregador ||
                    this.Entregador != null &&
                    this.Entregador.Equals(other.Entregador)
                ) && 
                (
                    this.DataCriacao == other.DataCriacao ||
                    this.DataCriacao != null &&
                    this.DataCriacao.Equals(other.DataCriacao)
                ) && 
                (
                    this.AcaoBloqueio == other.AcaoBloqueio ||
                    this.AcaoBloqueio != null &&
                    this.AcaoBloqueio.Equals(other.AcaoBloqueio)
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
                if (this.CodigoObjeto != null)
                    hash = hash * 59 + this.CodigoObjeto.GetHashCode();
                if (this.TipoEvento != null)
                    hash = hash * 59 + this.TipoEvento.GetHashCode();
                if (this.StatusEvento != null)
                    hash = hash * 59 + this.StatusEvento.GetHashCode();
                if (this.DescricaoEvento != null)
                    hash = hash * 59 + this.DescricaoEvento.GetHashCode();
                if (this.NomeUnidade != null)
                    hash = hash * 59 + this.NomeUnidade.GetHashCode();
                if (this.CodigoSRO != null)
                    hash = hash * 59 + this.CodigoSRO.GetHashCode();
                if (this.Municipio != null)
                    hash = hash * 59 + this.Municipio.GetHashCode();
                if (this.Uf != null)
                    hash = hash * 59 + this.Uf.GetHashCode();
                if (this.CodigoMCU != null)
                    hash = hash * 59 + this.CodigoMCU.GetHashCode();
                if (this.CodigoDR != null)
                    hash = hash * 59 + this.CodigoDR.GetHashCode();
                if (this.SiglaDR != null)
                    hash = hash * 59 + this.SiglaDR.GetHashCode();
                if (this.NumeroLista != null)
                    hash = hash * 59 + this.NumeroLista.GetHashCode();
                if (this.Estacao != null)
                    hash = hash * 59 + this.Estacao.GetHashCode();
                if (this.Usuario != null)
                    hash = hash * 59 + this.Usuario.GetHashCode();
                if (this.DataGravacao != null)
                    hash = hash * 59 + this.DataGravacao.GetHashCode();
                if (this.Entregador != null)
                    hash = hash * 59 + this.Entregador.GetHashCode();
                if (this.DataCriacao != null)
                    hash = hash * 59 + this.DataCriacao.GetHashCode();
                if (this.AcaoBloqueio != null)
                    hash = hash * 59 + this.AcaoBloqueio.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}