FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["MicroserviceTask.ApiGateway/MicroserviceTask.ApiGateway.csproj", "MicroserviceTask.ApiGateway/"]
RUN dotnet restore "MicroserviceTask.ApiGateway/MicroserviceTask.ApiGateway.csproj"
COPY . .
WORKDIR "/src/MicroserviceTask.ApiGateway"
RUN dotnet build "MicroserviceTask.ApiGateway.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MicroserviceTask.ApiGateway.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MicroserviceTask.ApiGateway.dll"]