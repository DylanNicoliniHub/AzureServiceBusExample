<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="MatterManagerCloudServiceBusWorkerRole" generation="1" functional="0" release="0" Id="1e107cd8-d288-4311-b7e8-9407bb3ed866" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="MatterManagerCloudServiceBusWorkerRoleGroup" generation="1" functional="0" release="0">
      <settings>
        <aCS name="WorkerRoleWithSBQueue1:Microsoft.ServiceBus.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/MatterManagerCloudServiceBusWorkerRole/MatterManagerCloudServiceBusWorkerRoleGroup/MapWorkerRoleWithSBQueue1:Microsoft.ServiceBus.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="WorkerRoleWithSBQueue1:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/MatterManagerCloudServiceBusWorkerRole/MatterManagerCloudServiceBusWorkerRoleGroup/MapWorkerRoleWithSBQueue1:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="WorkerRoleWithSBQueue1Instances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/MatterManagerCloudServiceBusWorkerRole/MatterManagerCloudServiceBusWorkerRoleGroup/MapWorkerRoleWithSBQueue1Instances" />
          </maps>
        </aCS>
      </settings>
      <maps>
        <map name="MapWorkerRoleWithSBQueue1:Microsoft.ServiceBus.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/MatterManagerCloudServiceBusWorkerRole/MatterManagerCloudServiceBusWorkerRoleGroup/WorkerRoleWithSBQueue1/Microsoft.ServiceBus.ConnectionString" />
          </setting>
        </map>
        <map name="MapWorkerRoleWithSBQueue1:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/MatterManagerCloudServiceBusWorkerRole/MatterManagerCloudServiceBusWorkerRoleGroup/WorkerRoleWithSBQueue1/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapWorkerRoleWithSBQueue1Instances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/MatterManagerCloudServiceBusWorkerRole/MatterManagerCloudServiceBusWorkerRoleGroup/WorkerRoleWithSBQueue1Instances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="WorkerRoleWithSBQueue1" generation="1" functional="0" release="0" software="C:\Users\dnicolini\Source\Workspaces\Workspace2\MatterManagerEnterprise\MatterManagerEnterprise\MatterManagerCloudServiceBusWorkerRole\csx\Release\roles\WorkerRoleWithSBQueue1" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaWorkerHost.exe " memIndex="1792" hostingEnvironment="consoleroleadmin" hostingEnvironmentVersion="2">
            <settings>
              <aCS name="Microsoft.ServiceBus.ConnectionString" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;WorkerRoleWithSBQueue1&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;WorkerRoleWithSBQueue1&quot; /&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/MatterManagerCloudServiceBusWorkerRole/MatterManagerCloudServiceBusWorkerRoleGroup/WorkerRoleWithSBQueue1Instances" />
            <sCSPolicyUpdateDomainMoniker name="/MatterManagerCloudServiceBusWorkerRole/MatterManagerCloudServiceBusWorkerRoleGroup/WorkerRoleWithSBQueue1UpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/MatterManagerCloudServiceBusWorkerRole/MatterManagerCloudServiceBusWorkerRoleGroup/WorkerRoleWithSBQueue1FaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyUpdateDomain name="WorkerRoleWithSBQueue1UpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyFaultDomain name="WorkerRoleWithSBQueue1FaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="WorkerRoleWithSBQueue1Instances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
</serviceModel>