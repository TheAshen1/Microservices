FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["MicroserviceTask.UI/MicroserviceTask.UI.csproj", "MicroserviceTask.UI/"]
RUN dotnet restore "MicroserviceTask.UI/MicroserviceTask.UI.csproj"
COPY . .
WORKDIR "/src/MicroserviceTask.UI"
RUN dotnet build "MicroserviceTask.UI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MicroserviceTask.UI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MicroserviceTask.UI.dll"]