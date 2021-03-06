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


class NovoCartaoPortadorContato(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self, email=None, tel_residencial=None, tel_celular=None):
        """
        NovoCartaoPortadorContato - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'email': 'str',
            'tel_residencial': 'str',
            'tel_celular': 'str'
        }

        self.attribute_map = {
            'email': 'email',
            'tel_residencial': 'telResidencial',
            'tel_celular': 'telCelular'
        }

        self._email = email
        self._tel_residencial = tel_residencial
        self._tel_celular = tel_celular

    @property
    def email(self):
        """
        Gets the email of this NovoCartaoPortadorContato.
        Endereço de email do portador do cartão.

        :return: The email of this NovoCartaoPortadorContato.
        :rtype: str
        """
        return self._email

    @email.setter
    def email(self, email):
        """
        Sets the email of this NovoCartaoPortadorContato.
        Endereço de email do portador do cartão.

        :param email: The email of this NovoCartaoPortadorContato.
        :type: str
        """

        self._email = email

    @property
    def tel_residencial(self):
        """
        Gets the tel_residencial of this NovoCartaoPortadorContato.
        Número do telefone residencial do portador do cartão.

        :return: The tel_residencial of this NovoCartaoPortadorContato.
        :rtype: str
        """
        return self._tel_residencial

    @tel_residencial.setter
    def tel_residencial(self, tel_residencial):
        """
        Sets the tel_residencial of this NovoCartaoPortadorContato.
        Número do telefone residencial do portador do cartão.

        :param tel_residencial: The tel_residencial of this NovoCartaoPortadorContato.
        :type: str
        """

        self._tel_residencial = tel_residencial

    @property
    def tel_celular(self):
        """
        Gets the tel_celular of this NovoCartaoPortadorContato.
        Número do telefone celular do portador do cartão.

        :return: The tel_celular of this NovoCartaoPortadorContato.
        :rtype: str
        """
        return self._tel_celular

    @tel_celular.setter
    def tel_celular(self, tel_celular):
        """
        Sets the tel_celular of this NovoCartaoPortadorContato.
        Número do telefone celular do portador do cartão.

        :param tel_celular: The tel_celular of this NovoCartaoPortadorContato.
        :type: str
        """

        self._tel_celular = tel_celular

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
