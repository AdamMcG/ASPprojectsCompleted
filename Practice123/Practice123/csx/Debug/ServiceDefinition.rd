<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="Practice123" generation="1" functional="0" release="0" Id="5ade24c7-7583-4d1d-89c3-a7b7ab21a834" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="Practice123Group" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="Practice 123:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/Practice123/Practice123Group/LB:Practice 123:Endpoint1" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="Practice 123:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/Practice123/Practice123Group/MapPractice 123:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="Practice 123Instances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/Practice123/Practice123Group/MapPractice 123Instances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:Practice 123:Endpoint1">
          <toPorts>
            <inPortMoniker name="/Practice123/Practice123Group/Practice 123/Endpoint1" />
          </toPorts>
        </lBChannel>
      </channels>
      <maps>
        <map name="MapPractice 123:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/Practice123/Practice123Group/Practice 123/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapPractice 123Instances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/Practice123/Practice123Group/Practice 123Instances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="Practice 123" generation="1" functional="0" release="0" software="C:\Users\AdamM\documents\visual studio 2015\Projects\Practice123\Practice123\csx\Debug\roles\Practice 123" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="-1" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
            </componentports>
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;Practice 123&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;Practice 123&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/Practice123/Practice123Group/Practice 123Instances" />
            <sCSPolicyUpdateDomainMoniker name="/Practice123/Practice123Group/Practice 123UpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/Practice123/Practice123Group/Practice 123FaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyUpdateDomain name="Practice 123UpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyFaultDomain name="Practice 123FaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="Practice 123Instances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="56327e95-250a-419b-a7e8-db01b2048553" ref="Microsoft.RedDog.Contract\ServiceContract\Practice123Contract@ServiceDefinition">
      <interfacereferences>
        <interfaceReference Id="e543c3d1-0b28-4696-a7c5-694594950bdc" ref="Microsoft.RedDog.Contract\Interface\Practice 123:Endpoint1@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/Practice123/Practice123Group/Practice 123:Endpoint1" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>