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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing EnderecoesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class EnderecoesApiTests
    {
        private EnderecoesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EnderecoesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EnderecoesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EnderecoesApi
            //Assert.IsInstanceOfType(typeof(EnderecoesApi), instance, "instance is a EnderecoesApi");
        }

        
        /// <summary>
        /// Test EnderecosCepGet
        /// </summary>
        [Test]
        public void EnderecosCepGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //string accessToken = null;
            //string cep = null;
            //var response = instance.EnderecosCepGet(clientId, accessToken, cep);
            //Assert.IsInstanceOf<List<InlineResponse2001>> (response, "response is List<InlineResponse2001>");
        }
        
    }

}
