/**
 * API dos Correios
 * Postal Object tracking API
 *
 * OpenAPI spec version: 1.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package io.swagger.client.api;

import io.swagger.client.ApiInvoker;
import io.swagger.client.ApiException;
import io.swagger.client.Pair;

import io.swagger.client.model.*;

import java.util.*;

import com.android.volley.Response;
import com.android.volley.VolleyError;

import io.swagger.client.model.InlineResponse2001;
import io.swagger.client.model.InlineResponse400;

import org.apache.http.HttpEntity;
import org.apache.http.entity.mime.MultipartEntityBuilder;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.concurrent.ExecutionException;
import java.util.concurrent.TimeoutException;

public class AddressesApi {
  String basePath = "https://api-visa.sensedia.com/sandbox/visa/correios/v1";
  ApiInvoker apiInvoker = ApiInvoker.getInstance();

  public void addHeader(String key, String value) {
    getInvoker().addDefaultHeader(key, value);
  }

  public ApiInvoker getInvoker() {
    return apiInvoker;
  }

  public void setBasePath(String basePath) {
    this.basePath = basePath;
  }

  public String getBasePath() {
    return basePath;
  }

  /**
  * 
  * Searches for the address of a given zipcodes.
   * @param clientId Customer identifier used for authentication.
   * @param accessToken Access token used in the authentication.
   * @param zipcode Zipcode to search.
   * @return List<InlineResponse2001>
  */
  public List<InlineResponse2001> addressesZipcodeGet (String clientId, String accessToken, String zipcode) throws TimeoutException, ExecutionException, InterruptedException, ApiException {
    Object postBody = null;
    // verify the required parameter 'clientId' is set
    if (clientId == null) {
      VolleyError error = new VolleyError("Missing the required parameter 'clientId' when calling addressesZipcodeGet",
        new ApiException(400, "Missing the required parameter 'clientId' when calling addressesZipcodeGet"));
    }
    // verify the required parameter 'accessToken' is set
    if (accessToken == null) {
      VolleyError error = new VolleyError("Missing the required parameter 'accessToken' when calling addressesZipcodeGet",
        new ApiException(400, "Missing the required parameter 'accessToken' when calling addressesZipcodeGet"));
    }
    // verify the required parameter 'zipcode' is set
    if (zipcode == null) {
      VolleyError error = new VolleyError("Missing the required parameter 'zipcode' when calling addressesZipcodeGet",
        new ApiException(400, "Missing the required parameter 'zipcode' when calling addressesZipcodeGet"));
    }

    // create path and map variables
    String path = "/addresses/{zipcode}".replaceAll("\\{format\\}","json").replaceAll("\\{" + "zipcode" + "\\}", apiInvoker.escapeString(zipcode.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    // header params
    Map<String, String> headerParams = new HashMap<String, String>();
    // form params
    Map<String, String> formParams = new HashMap<String, String>();
    headerParams.put("client_id", ApiInvoker.parameterToString(clientId));
    headerParams.put("access_token", ApiInvoker.parameterToString(accessToken));
    String[] contentTypes = {
    };
    String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

    if (contentType.startsWith("multipart/form-data")) {
      // file uploading
      MultipartEntityBuilder localVarBuilder = MultipartEntityBuilder.create();
      HttpEntity httpEntity = localVarBuilder.build();
      postBody = httpEntity;
    } else {
      // normal form params
    }

    String[] authNames = new String[] {  };

    try {
      String localVarResponse = apiInvoker.invokeAPI (basePath, path, "GET", queryParams, postBody, headerParams, formParams, contentType, authNames);
      if (localVarResponse != null) {
         return (List<InlineResponse2001>) ApiInvoker.deserialize(localVarResponse, "array", InlineResponse2001.class);
      } else {
         return null;
      }
    } catch (ApiException ex) {
       throw ex;
    } catch (InterruptedException ex) {
       throw ex;
    } catch (ExecutionException ex) {
       if (ex.getCause() instanceof VolleyError) {
         VolleyError volleyError = (VolleyError)ex.getCause();
         if (volleyError.networkResponse != null) {
           throw new ApiException(volleyError.networkResponse.statusCode, volleyError.getMessage());
         }
       }
       throw ex;
    } catch (TimeoutException ex) {
       throw ex;
    }
  }

      /**
   * 
   * Searches for the address of a given zipcodes.
   * @param clientId Customer identifier used for authentication.   * @param accessToken Access token used in the authentication.   * @param zipcode Zipcode to search.
  */
  public void addressesZipcodeGet (String clientId, String accessToken, String zipcode, final Response.Listener<List<InlineResponse2001>> responseListener, final Response.ErrorListener errorListener) {
    Object postBody = null;

  
    // verify the required parameter 'clientId' is set
    if (clientId == null) {
       VolleyError error = new VolleyError("Missing the required parameter 'clientId' when calling addressesZipcodeGet",
         new ApiException(400, "Missing the required parameter 'clientId' when calling addressesZipcodeGet"));
    }
    
    // verify the required parameter 'accessToken' is set
    if (accessToken == null) {
       VolleyError error = new VolleyError("Missing the required parameter 'accessToken' when calling addressesZipcodeGet",
         new ApiException(400, "Missing the required parameter 'accessToken' when calling addressesZipcodeGet"));
    }
    
    // verify the required parameter 'zipcode' is set
    if (zipcode == null) {
       VolleyError error = new VolleyError("Missing the required parameter 'zipcode' when calling addressesZipcodeGet",
         new ApiException(400, "Missing the required parameter 'zipcode' when calling addressesZipcodeGet"));
    }
    

    // create path and map variables
    String path = "/addresses/{zipcode}".replaceAll("\\{format\\}","json").replaceAll("\\{" + "zipcode" + "\\}", apiInvoker.escapeString(zipcode.toString()));

    // query params
    List<Pair> queryParams = new ArrayList<Pair>();
    // header params
    Map<String, String> headerParams = new HashMap<String, String>();
    // form params
    Map<String, String> formParams = new HashMap<String, String>();


    headerParams.put("client_id", ApiInvoker.parameterToString(clientId));
    headerParams.put("access_token", ApiInvoker.parameterToString(accessToken));

    String[] contentTypes = {
      
    };
    String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";

    if (contentType.startsWith("multipart/form-data")) {
      // file uploading
      MultipartEntityBuilder localVarBuilder = MultipartEntityBuilder.create();
      

      HttpEntity httpEntity = localVarBuilder.build();
      postBody = httpEntity;
    } else {
      // normal form params
          }

      String[] authNames = new String[] {  };

    try {
      apiInvoker.invokeAPI(basePath, path, "GET", queryParams, postBody, headerParams, formParams, contentType, authNames,
        new Response.Listener<String>() {
          @Override
          public void onResponse(String localVarResponse) {
            try {
              responseListener.onResponse((List<InlineResponse2001>) ApiInvoker.deserialize(localVarResponse,  "array", InlineResponse2001.class));
            } catch (ApiException exception) {
               errorListener.onErrorResponse(new VolleyError(exception));
            }
          }
      }, new Response.ErrorListener() {
          @Override
          public void onErrorResponse(VolleyError error) {
            errorListener.onErrorResponse(error);
          }
      });
    } catch (ApiException ex) {
      errorListener.onErrorResponse(new VolleyError(ex));
    }
  }
}
