/**
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

package io.swagger.client;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonDeserializationContext;
import com.google.gson.JsonDeserializer;
import com.google.gson.JsonElement;
import com.google.gson.JsonParseException;
import com.google.gson.reflect.TypeToken;
import java.lang.reflect.Type;
import java.util.List;
import java.util.Date;
import io.swagger.client.model.*;

public class JsonUtil {
  public static GsonBuilder gsonBuilder;

  static {
    gsonBuilder = new GsonBuilder();
    gsonBuilder.serializeNulls();
    gsonBuilder.setDateFormat("yyyy-MM-dd'T'HH:mm:ss.SSSZ");
    gsonBuilder.registerTypeAdapter(Date.class, new JsonDeserializer<Date>() {
      public Date deserialize(JsonElement json, Type typeOfT, JsonDeserializationContext context) throws JsonParseException {
        return new Date(json.getAsJsonPrimitive().getAsLong());
      }
    });
  }

  public static Gson getGson() {
    return gsonBuilder.create();
  }

  public static String serialize(Object obj){
    return getGson().toJson(obj);
  }

  public static <T> T deserializeToList(String jsonString, Class cls){
    return getGson().fromJson(jsonString, getListTypeForDeserialization(cls));
  }

  public static <T> T deserializeToObject(String jsonString, Class cls){
    return getGson().fromJson(jsonString, getTypeForDeserialization(cls));
  }

  public static Type getListTypeForDeserialization(Class cls) {
    String className = cls.getSimpleName();
    
    if ("CadastroBenificiario".equalsIgnoreCase(className)) {
      return new TypeToken<List<CadastroBenificiario>>(){}.getType();
    }
    
    if ("CartaoDisponivel".equalsIgnoreCase(className)) {
      return new TypeToken<List<CartaoDisponivel>>(){}.getType();
    }
    
    if ("DetalhamentoExtrato".equalsIgnoreCase(className)) {
      return new TypeToken<List<DetalhamentoExtrato>>(){}.getType();
    }
    
    if ("EnderecoPortador".equalsIgnoreCase(className)) {
      return new TypeToken<List<EnderecoPortador>>(){}.getType();
    }
    
    if ("ExtratoResponse".equalsIgnoreCase(className)) {
      return new TypeToken<List<ExtratoResponse>>(){}.getType();
    }
    
    if ("MsgErro".equalsIgnoreCase(className)) {
      return new TypeToken<List<MsgErro>>(){}.getType();
    }
    
    if ("NovoCartao".equalsIgnoreCase(className)) {
      return new TypeToken<List<NovoCartao>>(){}.getType();
    }
    
    if ("NovoCartaoPortador".equalsIgnoreCase(className)) {
      return new TypeToken<List<NovoCartaoPortador>>(){}.getType();
    }
    
    if ("NovoCartaoPortadorContato".equalsIgnoreCase(className)) {
      return new TypeToken<List<NovoCartaoPortadorContato>>(){}.getType();
    }
    
    if ("NovoCartaoPortadorEndereco".equalsIgnoreCase(className)) {
      return new TypeToken<List<NovoCartaoPortadorEndereco>>(){}.getType();
    }
    
    if ("Pagamento".equalsIgnoreCase(className)) {
      return new TypeToken<List<Pagamento>>(){}.getType();
    }
    
    if ("Portador".equalsIgnoreCase(className)) {
      return new TypeToken<List<Portador>>(){}.getType();
    }
    
    if ("PortadorResponse".equalsIgnoreCase(className)) {
      return new TypeToken<List<PortadorResponse>>(){}.getType();
    }
    
    if ("Saldo".equalsIgnoreCase(className)) {
      return new TypeToken<List<Saldo>>(){}.getType();
    }
    
    if ("SetCardStatus".equalsIgnoreCase(className)) {
      return new TypeToken<List<SetCardStatus>>(){}.getType();
    }
    
    if ("SetNovoCartao".equalsIgnoreCase(className)) {
      return new TypeToken<List<SetNovoCartao>>(){}.getType();
    }
    
    if ("SetPagamento".equalsIgnoreCase(className)) {
      return new TypeToken<List<SetPagamento>>(){}.getType();
    }
    
    if ("SetSaldo".equalsIgnoreCase(className)) {
      return new TypeToken<List<SetSaldo>>(){}.getType();
    }
    
    if ("SetSaldoValor".equalsIgnoreCase(className)) {
      return new TypeToken<List<SetSaldoValor>>(){}.getType();
    }
    
    if ("SetTransferencia".equalsIgnoreCase(className)) {
      return new TypeToken<List<SetTransferencia>>(){}.getType();
    }
    
    if ("StatusCartaoResponse".equalsIgnoreCase(className)) {
      return new TypeToken<List<StatusCartaoResponse>>(){}.getType();
    }
    
    if ("Transferencia".equalsIgnoreCase(className)) {
      return new TypeToken<List<Transferencia>>(){}.getType();
    }
    
    if ("TransferenciaCadastroBenificiario".equalsIgnoreCase(className)) {
      return new TypeToken<List<TransferenciaCadastroBenificiario>>(){}.getType();
    }
    
    if ("Valor".equalsIgnoreCase(className)) {
      return new TypeToken<List<Valor>>(){}.getType();
    }
    
    return new TypeToken<List<Object>>(){}.getType();
  }

  public static Type getTypeForDeserialization(Class cls) {
    String className = cls.getSimpleName();
    
    if ("CadastroBenificiario".equalsIgnoreCase(className)) {
      return new TypeToken<CadastroBenificiario>(){}.getType();
    }
    
    if ("CartaoDisponivel".equalsIgnoreCase(className)) {
      return new TypeToken<CartaoDisponivel>(){}.getType();
    }
    
    if ("DetalhamentoExtrato".equalsIgnoreCase(className)) {
      return new TypeToken<DetalhamentoExtrato>(){}.getType();
    }
    
    if ("EnderecoPortador".equalsIgnoreCase(className)) {
      return new TypeToken<EnderecoPortador>(){}.getType();
    }
    
    if ("ExtratoResponse".equalsIgnoreCase(className)) {
      return new TypeToken<ExtratoResponse>(){}.getType();
    }
    
    if ("MsgErro".equalsIgnoreCase(className)) {
      return new TypeToken<MsgErro>(){}.getType();
    }
    
    if ("NovoCartao".equalsIgnoreCase(className)) {
      return new TypeToken<NovoCartao>(){}.getType();
    }
    
    if ("NovoCartaoPortador".equalsIgnoreCase(className)) {
      return new TypeToken<NovoCartaoPortador>(){}.getType();
    }
    
    if ("NovoCartaoPortadorContato".equalsIgnoreCase(className)) {
      return new TypeToken<NovoCartaoPortadorContato>(){}.getType();
    }
    
    if ("NovoCartaoPortadorEndereco".equalsIgnoreCase(className)) {
      return new TypeToken<NovoCartaoPortadorEndereco>(){}.getType();
    }
    
    if ("Pagamento".equalsIgnoreCase(className)) {
      return new TypeToken<Pagamento>(){}.getType();
    }
    
    if ("Portador".equalsIgnoreCase(className)) {
      return new TypeToken<Portador>(){}.getType();
    }
    
    if ("PortadorResponse".equalsIgnoreCase(className)) {
      return new TypeToken<PortadorResponse>(){}.getType();
    }
    
    if ("Saldo".equalsIgnoreCase(className)) {
      return new TypeToken<Saldo>(){}.getType();
    }
    
    if ("SetCardStatus".equalsIgnoreCase(className)) {
      return new TypeToken<SetCardStatus>(){}.getType();
    }
    
    if ("SetNovoCartao".equalsIgnoreCase(className)) {
      return new TypeToken<SetNovoCartao>(){}.getType();
    }
    
    if ("SetPagamento".equalsIgnoreCase(className)) {
      return new TypeToken<SetPagamento>(){}.getType();
    }
    
    if ("SetSaldo".equalsIgnoreCase(className)) {
      return new TypeToken<SetSaldo>(){}.getType();
    }
    
    if ("SetSaldoValor".equalsIgnoreCase(className)) {
      return new TypeToken<SetSaldoValor>(){}.getType();
    }
    
    if ("SetTransferencia".equalsIgnoreCase(className)) {
      return new TypeToken<SetTransferencia>(){}.getType();
    }
    
    if ("StatusCartaoResponse".equalsIgnoreCase(className)) {
      return new TypeToken<StatusCartaoResponse>(){}.getType();
    }
    
    if ("Transferencia".equalsIgnoreCase(className)) {
      return new TypeToken<Transferencia>(){}.getType();
    }
    
    if ("TransferenciaCadastroBenificiario".equalsIgnoreCase(className)) {
      return new TypeToken<TransferenciaCadastroBenificiario>(){}.getType();
    }
    
    if ("Valor".equalsIgnoreCase(className)) {
      return new TypeToken<Valor>(){}.getType();
    }
    
    return new TypeToken<Object>(){}.getType();
  }

};