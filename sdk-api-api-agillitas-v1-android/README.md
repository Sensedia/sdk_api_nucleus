# swagger-android-client

## Requirements

Building the API client library requires [Maven](https://maven.apache.org/) to be installed.

## Installation

To install the API client library to your local Maven repository, simply execute:

```shell
mvn install
```

To deploy it to a remote Maven repository instead, configure the settings of the repository and execute:

```shell
mvn deploy
```

Refer to the [official documentation](https://maven.apache.org/plugins/maven-deploy-plugin/usage.html) for more information.

### Maven users

Add this dependency to your project's POM:

```xml
<dependency>
    <groupId>io.swagger</groupId>
    <artifactId>swagger-android-client</artifactId>
    <version>1.0.0</version>
    <scope>compile</scope>
</dependency>
```

### Gradle users

Add this dependency to your project's build file:

```groovy
compile "io.swagger:swagger-android-client:1.0.0"
```

### Others

At first generate the JAR by executing:

    mvn package

Then manually install the following JARs:

* target/swagger-android-client-1.0.0.jar
* target/lib/*.jar

## Getting Started

Please follow the [installation](#installation) instruction and execute the following Java code:

```java

import io.swagger.client.api.CartoesApi;

public class CartoesApiExample {

    public static void main(String[] args) {
        CartoesApi apiInstance = new CartoesApi();
        String tipoCartao = "fisico"; // String | Identifica qual o tipo do cartão, físico ou virtual.
        try {
            CartaoDisponivel result = apiInstance.cartoesGet(tipoCartao);
            System.out.println(result);
        } catch (ApiException e) {
            System.err.println("Exception when calling CartoesApi#cartoesGet");
            e.printStackTrace();
        }
    }
}

```

## Documentation for API Endpoints

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CartoesApi* | [**cartoesGet**](docs/CartoesApi.md#cartoesGet) | **GET** /cartoes | Obtém o número de identificação (Proxy) de um cartão
*CartoesApi* | [**cartoesIdCartaoExtratoGet**](docs/CartoesApi.md#cartoesIdCartaoExtratoGet) | **GET** /cartoes/{idCartao}/extrato | Extrato do cartão
*CartoesApi* | [**cartoesIdCartaoPortadorGet**](docs/CartoesApi.md#cartoesIdCartaoPortadorGet) | **GET** /cartoes/{idCartao}/portador | Informações do portador do cartão
*CartoesApi* | [**cartoesIdCartaoSaldoGet**](docs/CartoesApi.md#cartoesIdCartaoSaldoGet) | **GET** /cartoes/{idCartao}/saldo | Saldo do cartão
*CartoesApi* | [**cartoesIdCartaoSaldoPut**](docs/CartoesApi.md#cartoesIdCartaoSaldoPut) | **PUT** /cartoes/{idCartao}/saldo | Credita ou debita valor da conta de um cartão.
*CartoesApi* | [**cartoesIdCartaoStatusGet**](docs/CartoesApi.md#cartoesIdCartaoStatusGet) | **GET** /cartoes/{idCartao}/status | Status do cartão
*CartoesApi* | [**cartoesIdCartaoStatusPut**](docs/CartoesApi.md#cartoesIdCartaoStatusPut) | **PUT** /cartoes/{idCartao}/status | Altera status do cartão
*CartoesApi* | [**cartoesPost**](docs/CartoesApi.md#cartoesPost) | **POST** /cartoes | Requisita um cartão de debito
*PagamentosApi* | [**pagamentosPost**](docs/PagamentosApi.md#pagamentosPost) | **POST** /pagamentos | Pagamento de boletos.
*TransferenciasApi* | [**transferenciasCadastrosPost**](docs/TransferenciasApi.md#transferenciasCadastrosPost) | **POST** /transferencias/cadastros | Cadastro de beneficiário
*TransferenciasApi* | [**transferenciasPost**](docs/TransferenciasApi.md#transferenciasPost) | **POST** /transferencias | Transferência de valor


## Documentation for Models

 - [CadastroBenificiario](docs/CadastroBenificiario.md)
 - [CartaoDisponivel](docs/CartaoDisponivel.md)
 - [DetalhamentoExtrato](docs/DetalhamentoExtrato.md)
 - [EnderecoPortador](docs/EnderecoPortador.md)
 - [ExtratoResponse](docs/ExtratoResponse.md)
 - [MsgErro](docs/MsgErro.md)
 - [NovoCartao](docs/NovoCartao.md)
 - [NovoCartaoPortador](docs/NovoCartaoPortador.md)
 - [NovoCartaoPortadorContato](docs/NovoCartaoPortadorContato.md)
 - [NovoCartaoPortadorEndereco](docs/NovoCartaoPortadorEndereco.md)
 - [Pagamento](docs/Pagamento.md)
 - [Portador](docs/Portador.md)
 - [PortadorResponse](docs/PortadorResponse.md)
 - [Saldo](docs/Saldo.md)
 - [SetCardStatus](docs/SetCardStatus.md)
 - [SetNovoCartao](docs/SetNovoCartao.md)
 - [SetPagamento](docs/SetPagamento.md)
 - [SetSaldo](docs/SetSaldo.md)
 - [SetSaldoValor](docs/SetSaldoValor.md)
 - [SetTransferencia](docs/SetTransferencia.md)
 - [StatusCartaoResponse](docs/StatusCartaoResponse.md)
 - [Transferencia](docs/Transferencia.md)
 - [TransferenciaCadastroBenificiario](docs/TransferenciaCadastroBenificiario.md)
 - [Valor](docs/Valor.md)


## Documentation for Authorization

Authentication schemes defined for the API:
### access_token

- **Type**: API key
- **API key parameter name**: access_token
- **Location**: HTTP header

### client_id

- **Type**: API key
- **API key parameter name**: client_id
- **Location**: HTTP header

### key_id

- **Type**: API key
- **API key parameter name**: api_key
- **Location**: HTTP header


## Recommendation

It's recommended to create an instance of `ApiClient` per thread in a multithreaded environment to avoid any potential issues.

## Author



