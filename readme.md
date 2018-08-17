# Camunda Process Template

.NET Core console template that provides a harnas for deploying your BPMN flows as resources to Camunda and build external task workers.

## Install template
```
dotnet new -i camundaprocesstemplate
```
The template **CamundaProcess** should now appear in the .NET core template list

| Templates |  Short Name | Language |Tags|
|:---|:---|:---|:---|
|Console Application|console|[C#], F#, VB|Common/Console| 
Class library| classlib| [C#], F#, VB |Common/Library|
|.......|....... |....... |...... |
|**Camunda Console Process Template**| **CamundaProcess**|**[C#]**| **Console/BPMN/Camunda**
ASP . NET Core with Angular|angular|[C#]|Web/MVC/SPA|
|.......|....... |....... |...... |

You can also run the build-template.bat file from the command line, to build the template locally.

## Uninstall template
```
dotnet new -u camundaprocesstemplate
```

## Using the template

Create a folder that reflects the name of your api i.e. my-process
From within the folder execute the following command:

```
dotnet new camundaprocess
```

my-process.csproj should now have been created, and the namespace should also reflect MyAPI in the source code files.

### Building Docker Images

The docker compose yaml will automatically reflect your namespaces/projectname.

```
docker-compose up --build
```

After successfull build, the following should appear.

```
Successfully built 0d5e7aa7cced
Successfully tagged t2:latest
Creating t2_api_1 ... done
Attaching to t2_api_1
api_1  |
api_1  |  __      __.___  ________________     _____ .______________
api_1  | /  \    /  |   |/  _____/\_____  \   /  |  ||   \__    ___/
api_1  | \   \/\/   |   /   \  ___ /   |   \ /   |  ||   | |    |
api_1  |  \        /|   \    \_\  /    |    /    ^   |   | |    |
api_1  |   \__/\  / |___|\______  \_______  \____   ||___| |____|
api_1  |        \/              \/        \/     |__|
api_1  |
api_1  | t2 camunda processes
api_1  |
api_1  | Deploying models and start External Task Workers.
api_1  |
api_1  | PRESS Ctrl-C TO STOP WORKERS.
api_1  |
api_1  |
````

You can put your camunda bpmn models, forms and script in the resource directory and they'll be deployed to the engine.