=begin
#API dos Correios

#Postal Object tracking API

OpenAPI spec version: 1.0

Generated by: https://github.com/swagger-api/swagger-codegen.git

=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for SwaggerClient::EventsDetails
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'EventsDetails' do
  before do
    # run before each test
    @instance = SwaggerClient::EventsDetails.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of EventsDetails' do
    it 'should create an instact of EventsDetails' do
      expect(@instance).to be_instance_of(SwaggerClient::EventsDetails)
    end
  end
  describe 'test attribute "event_type"' do
    it 'should work' do
       # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "event_status"' do
    it 'should work' do
       # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "event_description"' do
    it 'should work' do
       # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end

