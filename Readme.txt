Reference Of Project: https://testautomationu.applitools.com/bdd-with-specflow/

For Report Generation with Specflow Live Doc first Execute through CLI in my Case: 
First: dotnet test --filter Category=loanApplication or dotnet test

Second: livingdoc test-assembly C:\Users\hp\source\repos\SpecFlowProject1\SpecFlowProject1\bin\Debug\net6.0\SpecFlowProject1.dll -t C:\Users\hp\source\repos\SpecFlowProject1\SpecFlowProject1\bin\Debug\net6.0\TestExecution.json --output C:\Users\hp\source\repos\SpecFlowProject1\SpecFlowProject1\Report\MyReport.html
Note Please change your Project Path accordingly.