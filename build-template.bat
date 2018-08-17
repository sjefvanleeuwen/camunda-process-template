@echo off


dotnet new -u CamundaProcessTemplate
nuget pack CamundaProcessTemplate.nuspec
dotnet new -i CamundaProcessTemplate.0.0.2.nupkg
