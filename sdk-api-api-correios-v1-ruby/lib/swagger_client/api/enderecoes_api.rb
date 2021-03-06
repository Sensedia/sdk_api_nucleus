=begin
#API dos Correios

#API de rastreios de Objetos Postais

OpenAPI spec version: 1.0

Generated by: https://github.com/swagger-api/swagger-codegen.git

=end

require "uri"

module SwaggerClient
  class EnderecoesApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end

    # 
    # Pesquisa pelo endereço de um dado CEP.
    # @param client_id Identificação do cliente usado na autenticação.
    # @param access_token Access token usado na autenticação.
    # @param cep CEP a ser pesquisado.
    # @param [Hash] opts the optional parameters
    # @return [Array<InlineResponse2001>]
    def enderecos_cep_get(client_id, access_token, cep, opts = {})
      data, _status_code, _headers = enderecos_cep_get_with_http_info(client_id, access_token, cep, opts)
      return data
    end

    # 
    # Pesquisa pelo endereço de um dado CEP.
    # @param client_id Identificação do cliente usado na autenticação.
    # @param access_token Access token usado na autenticação.
    # @param cep CEP a ser pesquisado.
    # @param [Hash] opts the optional parameters
    # @return [Array<(Array<InlineResponse2001>, Fixnum, Hash)>] Array<InlineResponse2001> data, response status code and response headers
    def enderecos_cep_get_with_http_info(client_id, access_token, cep, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: EnderecoesApi.enderecos_cep_get ..."
      end
      # verify the required parameter 'client_id' is set
      fail ArgumentError, "Missing the required parameter 'client_id' when calling EnderecoesApi.enderecos_cep_get" if client_id.nil?
      # verify the required parameter 'access_token' is set
      fail ArgumentError, "Missing the required parameter 'access_token' when calling EnderecoesApi.enderecos_cep_get" if access_token.nil?
      # verify the required parameter 'cep' is set
      fail ArgumentError, "Missing the required parameter 'cep' when calling EnderecoesApi.enderecos_cep_get" if cep.nil?
      # resource path
      local_var_path = "/enderecos/{cep}".sub('{format}','json').sub('{' + 'cep' + '}', cep.to_s)

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}
      header_params[:'client_id'] = client_id
      header_params[:'access_token'] = access_token

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      auth_names = []
      data, status_code, headers = @api_client.call_api(:GET, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Array<InlineResponse2001>')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: EnderecoesApi#enderecos_cep_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end
