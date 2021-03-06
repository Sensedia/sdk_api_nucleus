# coding: utf-8

"""
    API Agillitas Cartões Pré-pagos

    API para manipular recursos relacionadas à cartões pré-pagos Agillitas.

    OpenAPI spec version: 1.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


from pprint import pformat
from six import iteritems
import re


class CadastroBenificiario(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self, id_cartao=None, id_cartao_destino=None, nome=None, cpf=None):
        """
        CadastroBenificiario - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'id_cartao': 'float',
            'id_cartao_destino': 'float',
            'nome': 'str',
            'cpf': 'float'
        }

        self.attribute_map = {
            'id_cartao': 'idCartao',
            'id_cartao_destino': 'idCartaoDestino',
            'nome': 'nome',
            'cpf': 'cpf'
        }

        self._id_cartao = id_cartao
        self._id_cartao_destino = id_cartao_destino
        self._nome = nome
        self._cpf = cpf

    @property
    def id_cartao(self):
        """
        Gets the id_cartao of this CadastroBenificiario.
        Número identificador referente ao proxy do cartão origem de transferência.

        :return: The id_cartao of this CadastroBenificiario.
        :rtype: float
        """
        return self._id_cartao

    @id_cartao.setter
    def id_cartao(self, id_cartao):
        """
        Sets the id_cartao of this CadastroBenificiario.
        Número identificador referente ao proxy do cartão origem de transferência.

        :param id_cartao: The id_cartao of this CadastroBenificiario.
        :type: float
        """

        self._id_cartao = id_cartao

    @property
    def id_cartao_destino(self):
        """
        Gets the id_cartao_destino of this CadastroBenificiario.
        Número identificador referente ao proxy do cartão destino de transferência.

        :return: The id_cartao_destino of this CadastroBenificiario.
        :rtype: float
        """
        return self._id_cartao_destino

    @id_cartao_destino.setter
    def id_cartao_destino(self, id_cartao_destino):
        """
        Sets the id_cartao_destino of this CadastroBenificiario.
        Número identificador referente ao proxy do cartão destino de transferência.

        :param id_cartao_destino: The id_cartao_destino of this CadastroBenificiario.
        :type: float
        """

        self._id_cartao_destino = id_cartao_destino

    @property
    def nome(self):
        """
        Gets the nome of this CadastroBenificiario.
        Nome completo do beneficiário da transferência.

        :return: The nome of this CadastroBenificiario.
        :rtype: str
        """
        return self._nome

    @nome.setter
    def nome(self, nome):
        """
        Sets the nome of this CadastroBenificiario.
        Nome completo do beneficiário da transferência.

        :param nome: The nome of this CadastroBenificiario.
        :type: str
        """

        self._nome = nome

    @property
    def cpf(self):
        """
        Gets the cpf of this CadastroBenificiario.
        Numero do cadastro de pessoas física do beneficiário da transferência.

        :return: The cpf of this CadastroBenificiario.
        :rtype: float
        """
        return self._cpf

    @cpf.setter
    def cpf(self, cpf):
        """
        Sets the cpf of this CadastroBenificiario.
        Numero do cadastro de pessoas física do beneficiário da transferência.

        :param cpf: The cpf of this CadastroBenificiario.
        :type: float
        """

        self._cpf = cpf

    def to_dict(self):
        """
        Returns the model properties as a dict
        """
        result = {}

        for attr, _ in iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """
        Returns the string representation of the model
        """
        return pformat(self.to_dict())

    def __repr__(self):
        """
        For `print` and `pprint`
        """
        return self.to_str()

    def __eq__(self, other):
        """
        Returns true if both objects are equal
        """
        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """
        Returns true if both objects are not equal
        """
        return not self == other
