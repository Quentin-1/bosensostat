#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
FROM alpine:3.14 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM alpine:3.14 AS build
#RUN apk add bash icu-libs krb5-libs libgcc libintl libssl1.1 libstdc++ zlib 
#RUN apk -y snap 
#RUN snapd && snap install dotnet-sdk --classic --channel=6.0 && snap alias dotnet-sdk.dotnet dotnet
WORKDIR /src
COPY ["SensoStatWeb.WebApplication/SensoStatWeb.WebApplication.csproj", "SensoStatWeb.WebApplication/"]
RUN dotnet restore "SensoStatWeb.WebApplication/SensoStatWeb.WebApplication.csproj"
COPY . .
WORKDIR "/src/SensoStatWeb.WebApplication"
RUN dotnet build "SensoStatWeb.WebApplication.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SensoStatWeb.WebApplication.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SensoStatWeb.WebApplication.dll"]
