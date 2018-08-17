FROM microsoft/dotnet:2.1-runtime AS base
WORKDIR /app
EXPOSE 5080

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /apps
COPY . .
WORKDIR /apps
RUN dotnet restore -nowarn:msb3202,nu1503
RUN dotnet build --no-restore -c Release -o /app

FROM build AS publish
RUN dotnet publish --no-restore -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "template-identifier.dll"]